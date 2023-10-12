using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //Liste des commande ... par client
            /*/
            cbClients.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClients.DisplayMember = "NOMCLI";
            bsClients2.DataSource = Modele.listeClients();
            cbClients.DataSource = bsClients2;
            */

            cbClients.ValueMember = "NUMCLI";
            cbClients.DisplayMember = "nomComplet";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante

            bsClients2.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli,
                //x.Emailcli
            });
            cbClients.DataSource = bsClients2;
            cbClients.SelectedIndex = -1;


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
            */
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
                x.NumcliNavigation.Prenomcli,
            })
            .OrderBy(x => x.Datecde);
            dgvCommande.DataSource = bsCommande;


        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            FormGestionCommandes gestion = new FormGestionCommandes(EtatGestion.Create);
            gestion.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            FormGestionCommandes gestion = new FormGestionCommandes(EtatGestion.Update);
            gestion.ShowDialog();
        }
    }
}
