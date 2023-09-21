using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormGestionCommandes : Form
    {
        public FormGestionCommandes()
        {
            InitializeComponent();
        }

        private void dtpCommande_ValueChanged(object sender, EventArgs e)
        {
            dtpCommande.Enabled = true;
            dtpCommande.MinDate = new DateTime(2023, 08, 01);
        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {
            cbListeCli.ValueMember = "NUMCLI";
            cbListeCli.DisplayMember = "nomComplet";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante

            bsClients3.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli,
            });
            cbListeCli.DataSource = bsClients3;
            cbListeCli.SelectedIndex = -1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int montant = int.Parse(textMontant.Text);

                if (textMontant.Text == "" || montant <= 0)
                {
                    MessageBox.Show("Veuillez entre un montant entier positif pour la commande !");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez entre un montant entier positif pour la commande !");

            }

            if (cbListeCli.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un client pour la commande !");
            }

        }
    }
}
