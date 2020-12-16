using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project
{
    class Student
    {
        public string name;
        public Shape shape;
        public int id;

        public Student(string name, Shape shape, int id)
        {
            this.name = name;
            this.shape = shape;
            this.id = id;
        }
    }
}
