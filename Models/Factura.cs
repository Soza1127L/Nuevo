using System;
using System.Collections.Generic;

namespace FerreteriaApp.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public DateTime? FechaFactura { get; set; }

    public decimal? Total { get; set; }

    public int IdCliente { get; set; }

    public int IdEmpleado { get; set; }

    public int IdSucursal { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Sucursale IdSucursalNavigation { get; set; } = null!;
}
