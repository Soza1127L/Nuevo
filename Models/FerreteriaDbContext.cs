using Microsoft.EntityFrameworkCore;

namespace FerreteriaApp.Models;

public partial class FerreteriaDbContext : DbContext
{
    public FerreteriaDbContext() { }

    public FerreteriaDbContext(DbContextOptions<FerreteriaDbContext> options)
        : base(options) { }

    public virtual DbSet<Cliente> Clientes { get; set; }
    public virtual DbSet<Producto> Productos { get; set; }
    public virtual DbSet<Factura> Facturas { get; set; }
    public virtual DbSet<TiposProducto> TiposProductos { get; set; }
    public virtual DbSet<EntradasProducto> EntradasProductos { get; set; }
    public virtual DbSet<Empleado> Empleados { get; set; }
    public virtual DbSet<Proveedore> Proveedores { get; set; }
    public virtual DbSet<Sucursale> Sucursales { get; set; }
    public virtual DbSet<RedesSociale> RedesSociales { get; set; }
    public virtual DbSet<SalidasProducto> SalidasProductos { get; set; }
    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=FerreteriaDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 1. LLAVES PRIMARIAS (Aseguramos que todas existan)
        modelBuilder.Entity<Cliente>().HasKey(e => e.IdCliente);
        modelBuilder.Entity<Empleado>().HasKey(e => e.IdEmpleado);
        modelBuilder.Entity<Producto>().HasKey(e => e.IdProducto);
        modelBuilder.Entity<Proveedore>().HasKey(e => e.IdProveedor);
        modelBuilder.Entity<Sucursale>().HasKey(e => e.IdSucursal);
        modelBuilder.Entity<TiposProducto>().HasKey(e => e.IdTipoProducto);
        modelBuilder.Entity<Factura>().HasKey(e => e.IdFactura);
        modelBuilder.Entity<EntradasProducto>().HasKey(e => e.IdEntrada);
        modelBuilder.Entity<SalidasProducto>().HasKey(e => e.IdSalida);
        modelBuilder.Entity<RedesSociale>().HasKey(e => e.IdRedSocial);
        modelBuilder.Entity<DetalleFactura>().HasKey(e => e.IdDetalleFactura);

        // 2. CORRECCIÓN PARA EL ERROR DE GUARDADO (Relaciones de Producto)
        // Esto evita que el programa se caiga si los datos de relación son inconsistentes
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Productos");

            entity.HasOne(d => d.IdProveedorNavigation)
                .WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdSucursalNavigation)
                .WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdSucursal)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdTipoProductoNavigation)
                .WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdTipoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}