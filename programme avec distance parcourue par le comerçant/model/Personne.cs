using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WindowsFormsApp1.model
{
    class Personne
    {

        public string nom { get; set; }
        public Geometry position { get; set; }
        public int Id { get; set; }
        

        public Personne(string text)
        {

        }

        public Personne(int id, string nom , double x, double y)
        {
            this.Id = id;
            this.nom = nom;
            this.position = new Geometry(x, y);

        }

        public Personne(string textId, string textNom, string textX, string textY)
        {
            this.Id = int.Parse(textId);
            this.nom = textNom;
            this.position = new Geometry(textX,textY);
        }

        public Personne()
        {
        }
    }
}
