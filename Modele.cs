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

        public static List<Entities.Commande> listeCommande()
        {
            return monModel.Commandes.ToList();
        }
    }
}

