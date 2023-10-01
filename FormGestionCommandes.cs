using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Entities;

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
            int numCli = -1, montant = 0;
            DateTime dtCommande;

            if (textMontant.Text != "" || montant >= 0 && cbListeCli.SelectedIndex != -1)
            {
                // ajout possible si les champs monatnt et client sont remplis au moins
                if (Convert.ToInt32(textMontant.Text) >= 0 && Convert.ToInt32(textMontant.Text) <= 150)
                {
                    // ajout possible si le montant est correcte
                    montant = Convert.ToInt32(textMontant.Text);
                    dtCommande = dtpCommande.Value;
                    numCli = Convert.ToInt32(cbListeCli.SelectedValue);

                    if (Modele.AjoutCommande(montant, dtCommande, numCli))
                    {
                        MessageBox.Show("Commande ajoutée" + Modele.RetourneDerniereCommandeSaisie());
                        btn_annuler_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Ajout impossible : problème sur le montant", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ajout impossible : Il faut saisir au moins le montant et le client", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            textMontant.Clear();
            dtpCommande.Value = DateTime.Now;
            cbListeCli.SelectedIndex = -1;
        }

        /* BROUILLON
         *             try
            {
                int montant = int.Parse(textMontant.Text);
                //dtpCommande = DateTime(dtpCommande);

                if (textMontant.Text == "" || montant <= 0)
                {
                    MessageBox.Show("Veuillez entre un montant entier positif pour la commande !");
                }
                else
                {
                    if (cbListeCli.SelectedIndex == -1)
                    {
                        MessageBox.Show("Veuillez choisir un client pour la commande !");
                    }
                    else
                    {
                        using (var commande = new BddPartitionsBpContext())
                        {
                            DateOnly dtCommande = DateOnly.FromDateTime(dtpCommande.Value);
                            int numCli = int.Parse(cbListeCli.ValueMember);
                            var commandeClient = new Commande { Montantcde = montant, Datecde = dtCommande, Numcli = numCli};
                        }
                    }
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
         * 
         * 
         * 
         * 
         * */
    }
}
