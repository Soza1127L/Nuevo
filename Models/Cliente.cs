using System;
using System.Collections.Generic;

namespace FerreteriaApp.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }
    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
    public string? Direccion { get; set; }
    public DateTime? FechaRegistro { get; set; }
    public bool? Estado { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}