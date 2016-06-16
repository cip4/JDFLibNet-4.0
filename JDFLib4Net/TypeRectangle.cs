using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDFLib4Net
{
    public class TypeRectangle
    {
        public double Left = 0;
        public double Bottom = 0;
        public double Right = 0;
        public double Top = 0;

        public TypeRectangle(string value)
        {
            if (value != null)
            {
                string[] data = value.Trim().Split(' ');
                this.Left = Convert.ToDouble(data[0]);
                this.Bottom = Convert.ToDouble(data[1]);
                this.Right = Convert.ToDouble(data[2]);
                this.Top = Convert.ToDouble(data[3]);
            }
        }

    }
}
