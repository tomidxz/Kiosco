﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KioscoInformaticoBackend.Migrations
{
    /// <inheritdoc />
    public partial class inicioProyecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Oferta = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefonos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LocalidadId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefonos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cbu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CondicionIva = table.Column<int>(type: "int", nullable: false),
                    LocalidadId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Detallescompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductosId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detallescompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detallescompras_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormaPago = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Iva = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormaDePago = table.Column<int>(type: "int", nullable: false),
                    Iva = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Detallesventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detallesventas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detallesventas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detallesventas_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Detallescompras",
                columns: new[] { "Id", "Cantidad", "CompraId", "Eliminado", "PrecioUnitario", "ProductoId", "ProductosId" },
                values: new object[,]
                {
                    { 1, 1, 1, false, 2650m, null, 1 },
                    { 2, 2, 2, false, 2450m, null, 2 },
                    { 3, 1, 3, false, 2550m, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "San Justo" },
                    { 2, false, "Videla" },
                    { 3, false, "Escalada" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Eliminado", "Nombre", "Oferta", "Precio" },
                values: new object[,]
                {
                    { 1, false, "Coca Cola 2lts", false, 2650m },
                    { 2, false, "Sprite 2lts", false, 2450m },
                    { 3, false, "Fanta 2lts", false, 2550m }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Direccion", "Eliminado", "FechaNacimiento", "LocalidadId", "Nombre", "Telefonos" },
                values: new object[,]
                {
                    { 1, "Calle Falsa 123", false, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Juan Pérez", "123456789" },
                    { 2, "Avenida Siempre Viva 742", false, new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "María López", "987654321" },
                    { 3, "Boulevard de los Sueños Rotos 101", false, new DateTime(1978, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Carlos García", "555666777" },
                    { 4, "Ruta Nacional 19 Km 58", false, new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ana Martínez", "444555666" },
                    { 5, "Calle del Sol 456", false, new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Pedro Fernández", "333444555" }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "Id", "Cbu", "CondicionIva", "Direccion", "Eliminado", "LocalidadId", "Nombre", "Telefonos" },
                values: new object[,]
                {
                    { 1, "0000003100010000000001", 1, "Calle 1", false, 1, "Proveedor A", "111111111" },
                    { 2, "0000003100010000000002", 6, "Calle 2", false, 2, "Proveedor B", "222222222" },
                    { 3, "0000003100010000000003", 5, "Calle 3", false, 3, "Proveedor C", "333333333" },
                    { 4, "0000003100010000000004", 3, "Calle 4", false, 2, "Proveedor D", "444444444" },
                    { 5, "0000003100010000000005", 4, "Calle 5", false, 2, "Proveedor E", "555555555" },
                    { 6, "0000003100010000000006", 2, "Calle 6", false, 2, "Proveedor F", "666666666" },
                    { 7, "0000003100010000000007", 1, "Calle 7", false, 2, "Proveedor G", "777777777" },
                    { 8, "0000003100010000000008", 7, "Calle 8", false, 2, "Proveedor H", "888888888" },
                    { 9, "0000003100010000000009", 6, "Calle 9", false, 2, "Proveedor I", "999999999" },
                    { 10, "0000003100010000000010", 3, "Calle 10", false, 2, "Proveedor J", "101010101" }
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "Id", "Eliminado", "Fecha", "FormaDePago", "Iva", "ProveedorId", "Total" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 1, 1000 },
                    { 2, false, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2, 2000 },
                    { 3, false, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 3, 3000 },
                    { 4, false, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 4, 4000 }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "Id", "ClienteId", "Eliminado", "Fecha", "FormaPago", "Iva", "Total" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2024, 10, 8, 16, 22, 1, 550, DateTimeKind.Local).AddTicks(9142), 0, 21m, 3000m },
                    { 2, 2, false, new DateTime(2024, 10, 8, 16, 22, 1, 550, DateTimeKind.Local).AddTicks(9165), 1, 10m, 5000m },
                    { 3, 1, false, new DateTime(2024, 10, 8, 16, 22, 1, 550, DateTimeKind.Local).AddTicks(9168), 2, 21m, 8000m }
                });

            migrationBuilder.InsertData(
                table: "Detallesventas",
                columns: new[] { "Id", "Cantidad", "Eliminado", "PrecioUnitario", "ProductoId", "VentaId" },
                values: new object[,]
                {
                    { 1, 1, false, 2650m, 1, 1 },
                    { 2, 2, false, 2450m, 2, 2 },
                    { 3, 1, false, 2550m, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LocalidadId",
                table: "Clientes",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProveedorId",
                table: "Compras",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Detallescompras_ProductoId",
                table: "Detallescompras",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detallesventas_ProductoId",
                table: "Detallesventas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detallesventas_VentaId",
                table: "Detallesventas",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_LocalidadId",
                table: "Proveedores",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Detallescompras");

            migrationBuilder.DropTable(
                name: "Detallesventas");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Localidades");
        }
    }
}
