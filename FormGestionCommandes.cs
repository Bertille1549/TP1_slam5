using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Entities;

namespace TP1
{
    public enum EtatGestion
    {
        Create,
        Update
    }
    public partial class FormGestionCommandes : Form
    {
        private EtatGestion etat;
        public FormGestionCommandes(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat; // pour savoir si on est en create ou update
        }
        // bouton fermer
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpCommande_ValueChanged(object sender, EventArgs e)
        {
            dtpCommande.Enabled = true;
            dtpCommande.MinDate = new DateTime(2022, 09, 01);
        }

        private void dtpLivraison_ValueChanged(object sender, EventArgs e)
        {
            dtpLivraison.Enabled = true;
            dtpLivraison.MinDate = DateTime.Now;
        }

        private void remplirListeCommandes()
        {
            // remplir la combobox des commandes (si modification)
            cbCommandes.ValueMember = "Numcde";
            cbCommandes.DisplayMember = "Datecde";
            bsCommandes.DataSource = Modele.listeCommande();
            cbCommandes.DataSource = bsCommandes;
            //cbCommandes.SelectedIndex = -1;
        }

        public void remplirListeClient()
        {
            // remplir la combox des clients
            cbListeCli.ValueMember = "NUMCLI";
            cbListeCli.DisplayMember = "nomComplet";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante

            bsClients3.DataSource = (Modele.listeClients()).Select(x => new
            {
                //x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli,
            });
            cbListeCli.DataSource = bsClients3;
            //cbListeCli.SelectedIndex = -1;
        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {
            remplirListeClient();

            if (etat == EtatGestion.Create) // cas etat create
            {
                lblAM.Text = "Ajout d'une commande";
                btnAjout.Text = "Ajouter";
                gbInfo.Visible = true;
                cbCommandes.Visible = false;
            }
            else // cas etat update
            {
                lblAM.Text = "Modification d'une commande";
                btnAjout.Text = "Modifier";
                btnAjout.Visible = true;
                gbInfo.Visible = false;
                cbCommandes.Visible = true;
                remplirListeCommandes();
            }
        }

        private void textMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur dans le format de saisie de l'année (que des chiffres)", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            textMontant.Clear();
            dtpCommande.Value = DateTime.Now;
            cbListeCli.SelectedIndex = -1;
        }


        // Ajout et modification d'une commande en fonction de son état
        private void btnAjout_Click(object sender, EventArgs e)
        {
            int numCli = -1, montant = 0;
            DateTime dtCommande;
            DateTime dtLivraison;

            if (textMontant.Text != "" || montant >= 0 && cbListeCli.SelectedIndex != -1 || numCli != -1)
            {
                // ajout possible si les champs monatnt et client sont remplis au moins
                if (Convert.ToInt32(textMontant.Text) >= 0 && Convert.ToInt32(textMontant.Text) <= 150)
                {
                    // ajout possible si le montant est correcte
                    montant = Convert.ToInt32(textMontant.Text);
                    dtCommande = dtpCommande.Value;
                    numCli = Convert.ToInt32(cbListeCli.SelectedIndex + 1);
                    dtLivraison = dtpLivraison.Value;

                    DateOnly dateC = DateOnly.FromDateTime(dtCommande);
                    DateOnly dateL = DateOnly.FromDateTime(dtLivraison);

                    if (etat == EtatGestion.Create) // cas de l'ajout
                    {
                        if (Modele.AjoutCommande(montant, dtCommande, numCli, dtLivraison))
                        {
                            MessageBox.Show("Commande ajoutée " + Modele.RetourneDerniereCommandeSaisie());
                            btn_annuler_Click(sender, e);
                        }
                    }
                    if (etat == EtatGestion.Update) // cas de la mise à jour
                    {
                        Commande commande = (Commande)bsCommandes.Current;
                        if (Modele.ModifierCommande(commande.Numcde, montant, dateC, numCli))
                        {
                            MessageBox.Show("Commande modifiée");
                            gbInfo.Visible = false;
                            btnAjout.Visible = false;
                            cbCommandes.SelectedIndex = -1;
                            btn_annuler.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ajout impossible : problème sur le montant", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ajout impossible : Il faut saisir au moins le montant et le client", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bsCommandes_CurrentChanged(Object sender, EventArgs e)
        {
            // si 1 commande est sélectionnée dans la liste
            if (cbCommandes.SelectedIndex != -1)
            {
                // récup' de la commande sélectionnée
                Commande C = (Commande)bsCommandes.Current;

                //mise à jour des champs de la commande sélectionnée
                textMontant.Text = C.Montantcde.ToString();
                dtpCommande.Value = C.Datecde.Value.ToDateTime(TimeOnly.Parse("08:00"));
                cbListeCli.Text = C.NumcliNavigation.Nomcli;

                gbInfo.Visible = true;
                btnAjout.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void cbCommandes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsCommandes_CurrentChanged(sender, e);
        }


    }
}
