using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoShopManager.Migrations
{
    /// <inheritdoc />
    public partial class Partesss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Clientes_ClienteId",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Vehiculos_VehiculoId",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Reparacion_Vehiculos_VehiculoId",
                table: "Reparacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reparacion",
                table: "Reparacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cita",
                table: "Cita");

            migrationBuilder.RenameTable(
                name: "Reparacion",
                newName: "Reparaciones");

            migrationBuilder.RenameTable(
                name: "Cita",
                newName: "Citas");

            migrationBuilder.RenameIndex(
                name: "IX_Reparacion_VehiculoId",
                table: "Reparaciones",
                newName: "IX_Reparaciones_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cita_VehiculoId",
                table: "Citas",
                newName: "IX_Citas_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cita_ClienteId",
                table: "Citas",
                newName: "IX_Citas_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reparaciones",
                table: "Reparaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citas",
                table: "Citas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Partess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroParte = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partess", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Vehiculos_VehiculoId",
                table: "Citas",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparaciones_Vehiculos_VehiculoId",
                table: "Reparaciones",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Vehiculos_VehiculoId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reparaciones_Vehiculos_VehiculoId",
                table: "Reparaciones");

            migrationBuilder.DropTable(
                name: "Partess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reparaciones",
                table: "Reparaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citas",
                table: "Citas");

            migrationBuilder.RenameTable(
                name: "Reparaciones",
                newName: "Reparacion");

            migrationBuilder.RenameTable(
                name: "Citas",
                newName: "Cita");

            migrationBuilder.RenameIndex(
                name: "IX_Reparaciones_VehiculoId",
                table: "Reparacion",
                newName: "IX_Reparacion_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_VehiculoId",
                table: "Cita",
                newName: "IX_Cita_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_ClienteId",
                table: "Cita",
                newName: "IX_Cita_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reparacion",
                table: "Reparacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cita",
                table: "Cita",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Clientes_ClienteId",
                table: "Cita",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Vehiculos_VehiculoId",
                table: "Cita",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparacion_Vehiculos_VehiculoId",
                table: "Reparacion",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
