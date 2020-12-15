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
        private string name;
        private string[][] data;
        private int dimensions;

        public Shape(string name, string[][] data, int dimensions)
        {
            this.name = name;
            this.data = data;
            this.dimensions = dimensions;
        }
    }
}
