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

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Shape> shapes = new List<Shape>(); class YourItem
        {
            public string UserName { get; set; }
            public string UserId { get; set; }
        }

        class listClass
        {
            public string name;
            public string id;
        }

        public Form1()
        {
            InitializeComponent();
            ReadData();
            TestData();
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

        private void ReadData()
        {
            StreamReader sr = new StreamReader("data.csv");
            int id = 0;
            while (!sr.EndOfStream)
            {
                List<string[]> data = new List<string[]>();
                string name = sr.ReadLine();

                string[] line = sr.ReadLine().Split(',');
                Shape shape = new Shape(line[0], int.Parse(line[1]));

                for (int i = 0; i < shape.dimensions; i++)
                {
                    data.Add(sr.ReadLine().Split(','));
                }
                shape.Data = data;

                shapes.Add(shape);
                students.Add(new Student(name, shape, id));
                id++;
            }
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
    }
}
