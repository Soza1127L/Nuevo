using System;
using System.Collections.Generic;

namespace FerreteriaApp.Models;

public partial class Sucursale
{
    public int IdSucursal { get; set; }

    public string NombreSucursal { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Ciudad { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<RedesSociale> RedesSociales { get; set; } = new List<RedesSociale>();
}
