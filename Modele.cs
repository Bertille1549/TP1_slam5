using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Entities;

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
    }
}

