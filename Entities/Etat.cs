using System;
using System.Collections.Generic;

namespace TP1.Entities;

public partial class Etat
{
    public int Numetat { get; set; }

    public string Libelleetat { get; set; } = null!;

    public virtual ICollection<Livraison> Livraisons { get; set; } = new List<Livraison>();
}
