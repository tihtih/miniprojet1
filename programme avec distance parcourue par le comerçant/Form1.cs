using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.model;
using WpfApp1.model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private BD bd = new BD();
        Personne Comercial = new Personne();
        List<int> DejaVisite;
        List<Personne> ordre ;
        public double pdist { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grd.DataSource = bd.Clients.Select(c => new { c.Id, c.nom, c.position.X, c.position.Y }).ToList();

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Comercial = new Personne(textId.Text, textNom.Text, textX.Text, textY.Text);
            DejaVisite = new List<int>();
            ordre = new List<Personne>();
            Visiter(Comercial, bd.Clients);
            grdVisite.DataSource = ordre.Select(c => new { c.Id, 
                c.nom, 
                c.position.X,
                c.position.Y,
                dist = Helper.dist(c, Comercial),
                sdist = distTrajet(Comercial,c) // La distance total parcourue de 0 usqu'a le client c
            }).ToList(); 


        }
        private double distTrajet(Personne comercial, Personne c)
        {
            
            pdist = pdist + Helper.dist(comercial, c);

            return pdist;

        }

        private void Visiter(Personne comercial, List<Personne> Clients)
        { 
            Personne plusProche = TrouverPlusProche(comercial, Clients, DejaVisite);
                if(plusProche!=null)
            {   // distanceParcourue.Add
                ordre.Add(plusProche);
                DejaVisite.Add(plusProche.Id);
                Visiter(plusProche, Clients);
            }

        }

        private Personne TrouverPlusProche(Personne debut, List<Personne> clients, List<int> dejaVisite)
        {
            Personne proche = null;
            double minDist = double.MaxValue;

            foreach (Personne cli in clients)
            {
                if (!dejaVisite.Contains(cli.Id))
                {
                    double dist = Helper.Distance(debut, cli);
                    if (dist<minDist)
                    {
                        minDist = dist;
                        proche = cli;
                    }
                }
                
            }
            return proche;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
