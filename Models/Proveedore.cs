using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FerreteriaApp.Models;

public partial class Proveedore
{
    [Key]
    public int IdProveedor { get; set; }

    public string NombreProveedor { get; set; } = null!;

    public string? Contacto { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<EntradasProducto> EntradasProductos { get; set; } = new List<EntradasProducto>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}