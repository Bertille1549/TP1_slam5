using System;
using System.Collections.Generic;

namespace TP1.Entities;

public partial class Livraison
{
    public int Numliv { get; set; }

    public int Numcde { get; set; }

    public DateOnly Dateprevue { get; set; }

    public DateOnly Dateeffective { get; set; }

    public int Etat { get; set; }

    public virtual Etat EtatNavigation { get; set; } = null!;

    public virtual Commande NumcdeNavigation { get; set; } = null!;
}
