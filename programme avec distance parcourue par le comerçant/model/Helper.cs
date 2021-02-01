using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WindowsFormsApp1.model
{
    class Helper
    {
        double pdist;
        public static double Distance(Personne cli1, Personne cli2)
        {
           

            return Distance(cli1.position, cli2.position);
        }

        private static double Distance(Geometry p1, Geometry p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        internal static double dist(Personne cli1, Personne cli2)
        {   

            return Distance(cli1.position, cli2.position);
        }

        internal static object sdist(Personne c, Personne comercial, double pdist)
        {
            double dist=Distance(c.position, comercial.position);
            return 0;
        }
    }
}
