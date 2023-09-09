using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Entities;

namespace TP1
{
    public partial class TabAuteur : Form
    {
        public TabAuteur()
        {
            InitializeComponent();
        }

        private void TabAuteur_Load(object sender, EventArgs e)
        {
            bsAuteur.DataSource = Modele.listeAuteur(); //appel de la méthode listeAuteur
            dgvAuteur.DataSource = bsAuteur;
        }
    }
}
