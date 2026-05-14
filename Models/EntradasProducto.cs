using System;
using System.Collections.Generic;

namespace FerreteriaApp.Models;

public partial class EntradasProducto
{
    public int IdEntrada { get; set; }

    public DateTime? FechaEntrada { get; set; }

    public int Cantidad { get; set; }

    public decimal? PrecioCompra { get; set; }

    public int IdProducto { get; set; }

    public int IdProveedor { get; set; }

    public int IdEmpleado { get; set; }

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
}
