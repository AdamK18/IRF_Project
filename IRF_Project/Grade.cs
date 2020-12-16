using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project
{
    class Grade
    {
        public Student student;
        private int _grade = 0;
        public int grade
        {
            get { return _grade; }
            set
            {
                if(student.late == true)
                {
                    _grade = --value;
                }
                else
                {
                    _grade = value;
                }

                if (_grade < 1)
                {
                    _grade = 1;
                }
                else if (_grade > 5)
                {
                    _grade = 5;
                }
            }
        }

        public Grade(Student student)
        {
            this.student = student;
        }
    }
}
