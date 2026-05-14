using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // <--- SE AGREGÓ ESTA LÍNEA

namespace FerreteriaApp.Models;

public partial class Producto
{
    [Key] // <--- SE AGREGÓ ESTA ETIQUETA PARA QUITAR EL ERROR ROJO
    public int IdProducto { get; set; }

    [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
    public string NombreProducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "El precio de compra es obligatorio.")]
    public decimal? PrecioCompra { get; set; }

    [Required(ErrorMessage = "El precio de venta es obligatorio.")]
    public decimal? PrecioVenta { get; set; }

    public int? Stock { get; set; }

    public string? Marca { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un tipo de producto.")]
    [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un tipo de producto.")]
    public int? IdTipoProducto { get; set; }

    [Required(ErrorMessage = "Debe seleccionar un proveedor.")]
    [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un proveedor.")]
    public int? IdProveedor { get; set; }

    [Required(ErrorMessage = "Debe seleccionar una sucursal.")]
    [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una sucursal.")]
    public int? IdSucursal { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual ICollection<EntradasProducto> EntradasProductos { get; set; } = new List<EntradasProducto>();

    public virtual Proveedore? IdProveedorNavigation { get; set; }

    public virtual Sucursale? IdSucursalNavigation { get; set; }

    public virtual TiposProducto? IdTipoProductoNavigation { get; set; }

    public virtual ICollection<SalidasProducto> SalidasProductos { get; set; } = new List<SalidasProducto>();
}