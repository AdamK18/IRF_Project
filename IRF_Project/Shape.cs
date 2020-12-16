using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    class Shape : Button
    {
        public string name;
        public int dimensions;
        private List<string[]> _data;
        public List<string[]> Data
        {
            get { return _data; }
            set
            {
                _data = value;
            }
        }

        public Shape(string name, int dimensions)
        {
            this.name = name;
            this.dimensions = dimensions;
        }
    }
}
