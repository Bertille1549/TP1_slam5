using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;
using TP1.Entities;

namespace TP1
{
    public partial class TabPartition : Form
    {
        public TabPartition()
        {
            InitializeComponent();
        }

        private void TabPartition_Load(object sender, EventArgs e)
        {
            bsPartition.DataSource = Modele.listePartition(); //appel de la méthode listePartition
            dgvPartition.DataSource = bsPartition;
        }




        /*
         * 
         *  private void TabCommande_Load(object sender, EventArgs e)
        {
            //Liste des commande ... par client
            /
        cbClients.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClients.DisplayMember = "NOMCLI";
            bsClients2.DataSource = Modele.listeClients();
            cbClients.DataSource = bsClients2;
            *

            cbClients.ValueMember = "NUMCLI";
            cbClients.DisplayMember = "nomComplet";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante

            bsClients2.DataSource = (Modele.listeClients()).Select(x => new {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli,
                //x.Emailcli
            });
            cbClients.DataSource = bsClients2;


            //bsCommande.DataSource = Modele.listeCommande(); //appel de la méthode listeCommande
            //appel de la méthode listeCommande avec un select pour n'afficher que les champs voulus
            /*
            bsCommande.DataSource = Modele.listeCommande().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });

            dgvCommande.DataSource = bsCommande;
            *
        }

        private void bsClients2_CurrentChanged(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IDC = Convert.ToInt32(cbClients.SelectedValue);
            int IdClient = Convert.ToInt32(cbClients.SelectedValue);
            bsCommande.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
            .OrderBy(x => x.Datecde);
            dgvCommande.DataSource = bsCommande;

        }
        */
    }
}
