using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace IRF_Project
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Shape> shapes = new List<Shape>();
        List<Button> buttons = new List<Button>();
        List<Grade> grades = new List<Grade>();

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public int initialxOffset = 250;
        public int initialyOffset = 80;
        public int xOffset;
        public int yOffset;
        public int buttonSize = 30;
        public int gap = 10;

        public Form1()
        {
            InitializeComponent();
            ReadData();
            TestData();
            init();
        }

        private void init()
        {
            Button grade = button_grade;
            Button export = button_export;
            label_grade.Text = "Grade:";
            xOffset = initialxOffset;
            yOffset = initialyOffset;
        }

        private void ReAlignBUttons()
        {
            Student currentStudent = students[list_students.SelectedIndex];
            for (int i = 0; i < currentStudent.shape.Data.Count(); i++)
            {
                string[] line = currentStudent.shape.Data[i];
                label_shape.Text = currentStudent.shape.name;
                label_shape.Left = initialxOffset + currentStudent.shape.dimensions * (buttonSize + gap) / 2 - label_shape.Width / 2 - gap / 2;
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == "x")
                    {
                        Button button = new Button
                        {
                            Left = xOffset,
                            Top = yOffset,
                            Width = buttonSize,
                            Height = buttonSize
                        };
                        buttons.Add(button);
                        this.Controls.Add(button);
                    }
                    xOffset += buttonSize + gap;
                }
                xOffset = initialxOffset;
                yOffset += buttonSize + gap;
            }
        }

        private void ReadData()
        {
            StreamReader sr = new StreamReader("data/data.csv");
            int id = 0;
            while (!sr.EndOfStream)
            {
                List<string[]> data = new List<string[]>();
                string[] student_data = sr.ReadLine().Split(',');

                string[] line = sr.ReadLine().Split(',');
                Shape shape = new Shape(line[0], int.Parse(line[1]));

                for (int i = 0; i < shape.dimensions; i++)
                {
                    data.Add(sr.ReadLine().Split(','));
                }
                shape.Data = data;

                Student student = new Student(student_data[0], shape, id, Convert.ToBoolean(student_data[1]));
                Grade grade = new Grade(student);

                grades.Add(grade);
                shapes.Add(shape);
                students.Add(student);
                id++;
            }
            AppendList();
        }

        private void AppendList()
        {
            foreach (Student student in students)
            {
                list_students.Items.Add(new KeyValuePair<string, int>(student.name, student.id));
            }
            list_students.DisplayMember = "key";
            list_students.ValueMember = "value";
        }

        private void TestData()
        {
            foreach (Student student in students)
            {
                Trace.WriteLine(student.name);
                Trace.WriteLine(student.shape.name + " " + student.shape.dimensions);
                for (int i = 0; i < student.shape.Data.Count(); i++)
                {
                    for (int j = 0; j < student.shape.Data[i].Count(); j++)
                    {
                        Trace.Write(student.shape.Data[i][j]);
                    }
                    Trace.WriteLine("");
                }
                Trace.WriteLine("");
            }
        }

        private void list_students_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Button button in buttons)
            {
                this.Controls.Remove(button);
            }
            buttons = new List<Button>();
            ReAlignBUttons();
            init();
        }

        private void button_grade_Click(object sender, EventArgs e)
        {
            if(list_students.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Please select a student");
                return;
            }
            int grade = 0;
            string input = "";
            try
            {
                input = textbox_grade.Text.ToString();
                grade = int.Parse(textbox_grade.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number!");
            }
            grades[list_students.SelectedIndex].grade = int.Parse(input);
            label_grade.Text = "Grade: " + grades[list_students.SelectedIndex].grade;
            Trace.WriteLine(grades[list_students.SelectedIndex].grade);
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            try { 
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                
                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            string[] headers = new string[] {
             "Name",
             "Grade",
            "Handed in late"};

            xlSheet.Cells[1, 1] = headers[0];
            xlSheet.Cells[1, 2] = headers[1];
            xlSheet.Cells[1, 3] = headers[2];

            for (int i = 0; i < grades.Count; i++)
            {
                xlSheet.Cells[i + 2, 1] = grades[i].student.name;
                xlSheet.Cells[i + 2, 2] = grades[i].grade;
                if (grades[i].student.late)
                {
                    xlSheet.Cells[i + 2, 3] = "true";
                }
                else
                {
                    xlSheet.Cells[i + 2, 3] = "false";
                }
            }

            FormatTable(headers);
        }

        private void FormatTable(string[] headers)
        {
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.Gray;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);


            Excel.Range contentRange = xlSheet.get_Range(GetCell(2, 1), GetCell(students.Count+1, 3));
            contentRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            contentRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            contentRange.EntireColumn.AutoFit();
            contentRange.Interior.Color = Color.LightGray;
            contentRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
    }
}
