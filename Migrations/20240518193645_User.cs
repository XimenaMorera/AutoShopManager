using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoShopManager.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Vehiculos_VehiculoId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "IdVehiculo",
                table: "Reparaciones");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "IdVehiculo",
                table: "Citas");

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Vehiculos_VehiculoId",
                table: "Citas",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Vehiculos_VehiculoId",
                table: "Citas");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVehiculo",
                table: "Reparaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VehiculoId",
                table: "Citas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVehiculo",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Vehiculos_VehiculoId",
                table: "Citas",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id");
        }
    }
}
