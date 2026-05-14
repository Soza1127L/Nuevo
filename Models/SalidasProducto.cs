using System;
using System.Collections.Generic;

namespace FerreteriaApp.Models;

public partial class SalidasProducto
{
    public int IdSalida { get; set; }

    public DateTime? FechaSalida { get; set; }

    public int Cantidad { get; set; }

    public string? Motivo { get; set; }

    public int IdProducto { get; set; }

    public int IdEmpleado { get; set; }

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
