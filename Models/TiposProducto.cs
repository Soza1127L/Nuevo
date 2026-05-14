using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Agregado

namespace FerreteriaApp.Models;

public partial class TiposProducto
{
    [Key] // Agregado para que Entity Framework no se confunda
    public int IdTipoProducto { get; set; }

    public string NombreTipo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}