﻿using System;
using System.Collections.Generic;

namespace TP1.Entities;

public partial class Commande
{
    public int Numcli { get; set; }

    public int Numcde { get; set; }

    public DateOnly? Datecde { get; set; }

    public int? Montantcde { get; set; }

    public virtual ICollection<Livraison> Livraisons { get; set; } = new List<Livraison>();

    public virtual Client NumcliNavigation { get; set; } = null!;

    public virtual ICollection<Partition> Numparts { get; set; } = new List<Partition>();
}
