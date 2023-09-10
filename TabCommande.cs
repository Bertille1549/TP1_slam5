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
    public partial class TabCommande : Form
    {
        public TabCommande()
        {
            InitializeComponent();
        }

        private void TabCommande_Load(object sender, EventArgs e)
        {
            //bsCommande.DataSource = Modele.listeCommande(); //appel de la méthode listeCommande
            //appel de la méthode listeCommande avec un select pour n'afficher que les champs voulus
            bsCommande.DataSource = Modele.listeCommande().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvCommande.DataSource = bsCommande;
        }
    }
}
