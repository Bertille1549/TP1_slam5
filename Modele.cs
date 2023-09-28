using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TP1.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TP1
{
    internal static class Modele
    {
        private static BddPartitionsBpContext monModel;
        public static void init()
        {
            monModel = new BddPartitionsBpContext();
        }

        public static List<Entities.Client> listeClients()
        {
            return monModel.Clients.ToList();
        }

        public static List<Commande> listeCommande()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }

        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }


        public static List<Entities.Auteur> listeAuteur()
        {
            return monModel.Auteurs.ToList();
        }

        public static List<Entities.Partition> listePartition()
        {
            return monModel.Partitions.Include(a => a.NumstyleNavigation).ToList();
        }

        public static List<Entities.Style> listeStyle()
        {
            return monModel.Styles.ToList();
        }

        public static List<Partition> listePartitionParStyle(int idStyle)
        {
            List<Partition> lesPartitions = monModel.Partitions.Where(p => p.Numstyle ==
           idStyle).Include(p => p.NumstyleNavigation).ToList();
            return lesPartitions;
        }

        public static bool AjoutCommande(int montant, DateTime dateC, int idClient)
        {
            Commande maCommande;
            bool vretour = true;
            DateOnly dtC = DateOnly.FromDateTime(unDtpCommande);
            try
            {                
                maCommande = new Commande();
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = dtC; // la propriété DateCde est en date dans la BD et dans la classe Commande, modifier si besoin.
                maCommande.Numcli = idClient;
                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

    }
}

