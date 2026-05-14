using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // IMPORTANTE: Agregamos esto

namespace FerreteriaApp.Models;

public partial class Empleado
{
    [Key] // IMPORTANTE: Esto le dice a Blazor que esta es la Llave Primaria
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Cargo { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public decimal? Salario { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<EntradasProducto> EntradasProductos { get; set; } = new List<EntradasProducto>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<SalidasProducto> SalidasProductos { get; set; } = new List<SalidasProducto>();
}