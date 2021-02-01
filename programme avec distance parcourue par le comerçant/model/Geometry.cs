using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.model
{
    public class Geometry
    {

        public double X { get; set; }
        public double Y { get; set; }

        public Geometry()
        {

        }
        public Geometry(double x, double y)
        {
            this.X = x;
            this.Y = y;

        }

        public Geometry(string txtx, string txty)
        {
            this.X = double.Parse(txtx);
            this.Y = double.Parse(txty);

        }

    }
}
