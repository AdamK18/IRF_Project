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
        public bool late;

        public Student(string name, Shape shape, int id, bool late)
        {
            this.name = name;
            this.shape = shape;
            this.id = id;
            this.late = late;
        }
    }
}
