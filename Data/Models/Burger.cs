using System;
using System.Collections.Generic;

namespace Juliana_Sosa_API_Burger.Data.Models;

public partial class Burger
{
    public int BurgerId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool ConQueso { get; set; }

    public decimal Precio { get; set; }

    public virtual ICollection<Promo> Promos { get; set; } = new List<Promo>();
}
