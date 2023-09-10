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

        public static List<Entities.Auteur> listeAuteur()
        {
            return monModel.Auteurs.ToList();
        }

        public static List<Entities.Partition> listePartition()
        {
            return monModel.Partitions.ToList();
        }
    }
}

