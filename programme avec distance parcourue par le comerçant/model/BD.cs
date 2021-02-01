using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using WindowsFormsApp1.model;

namespace WpfApp1.model
{
    public class BD
    {

        //public List<Personne> Clients;
        internal List<Personne> Clients { get; set; }
        public BD()
        {
            Clients = new List<Personne>();
            Clients.Add(new Personne(1, "Ali", 10, 5));
            Clients.Add(new Personne(2, "Omar", 8, -3));
            Clients.Add(new Personne(3, "Rachida", 5, 2));
            Clients.Add(new Personne(4, "Karima", 1, 8));
            Clients.Add(new Personne(5, "Allal", 0, 3));
        }

        
    }
}
