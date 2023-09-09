using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void commande_Click(object sender, EventArgs e)
        {
            TabCommande commande = new TabCommande();
            commande.Show();
        }

        private void client_Click(object sender, EventArgs e)
        {
            Tableau client = new Tableau();
            client.Show();
        }

        private void partition_Click(object sender, EventArgs e)
        {
            TabPartition partition = new TabPartition();
            partition.Show();
        }

        private void auteur_Click(object sender, EventArgs e)
        {
            TabAuteur auteur = new TabAuteur();
            auteur.Show();
        }
    }
}
