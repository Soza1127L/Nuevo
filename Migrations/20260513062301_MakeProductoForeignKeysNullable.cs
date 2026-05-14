using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FerreteriaApp.Migrations
{
    /// <inheritdoc />
    public partial class MakeProductoForeignKeysNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Proveedores_IdProveedor",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Sucursales_IdSucursal",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_TiposProductos_IdTipoProducto",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoProducto",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdSucursal",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdProveedor",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Proveedores_IdProveedor",
                table: "Productos",
                column: "IdProveedor",
                principalTable: "Proveedores",
                principalColumn: "IdProveedor",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Sucursales_IdSucursal",
                table: "Productos",
                column: "IdSucursal",
                principalTable: "Sucursales",
                principalColumn: "IdSucursal",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_TiposProductos_IdTipoProducto",
                table: "Productos",
                column: "IdTipoProducto",
                principalTable: "TiposProductos",
                principalColumn: "IdTipoProducto",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Proveedores_IdProveedor",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Sucursales_IdSucursal",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_TiposProductos_IdTipoProducto",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoProducto",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdSucursal",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdProveedor",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Proveedores_IdProveedor",
                table: "Productos",
                column: "IdProveedor",
                principalTable: "Proveedores",
                principalColumn: "IdProveedor");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Sucursales_IdSucursal",
                table: "Productos",
                column: "IdSucursal",
                principalTable: "Sucursales",
                principalColumn: "IdSucursal");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_TiposProductos_IdTipoProducto",
                table: "Productos",
                column: "IdTipoProducto",
                principalTable: "TiposProductos",
                principalColumn: "IdTipoProducto");
        }
    }
}
