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
        List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("data.csv");
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
                students.Add(new Student(name, shape));
            }
        }
    }
}
