using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KioscoInformaticoBackend.Migrations
{
    /// <inheritdoc />
    public partial class ProyectoManwha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pais = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefonos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalDonado = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donadores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleados",
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
                    PuestoEmpleado = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Correo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Manwhas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capitulos = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Sinopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagenUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manwhas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Origenes",
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
                    table.PrimaryKey("PK_Origenes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ManwhaPedido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Donaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DonadorId = table.Column<int>(type: "int", nullable: false),
                    FormaPago = table.Column<int>(type: "int", nullable: false),
                    Iva = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donaciones_Empleados_DonadorId",
                        column: x => x.DonadorId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetallesTraducciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ManwhasId = table.Column<int>(type: "int", nullable: false),
                    ManwhaId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoEncargadoId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoTraductorId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoTyperId = table.Column<int>(type: "int", nullable: true),
                    EmpleadoCleanerId = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesTraducciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Empleados_EmpleadoCleanerId",
                        column: x => x.EmpleadoCleanerId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Empleados_EmpleadoEncargadoId",
                        column: x => x.EmpleadoEncargadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Empleados_EmpleadoTraductorId",
                        column: x => x.EmpleadoTraductorId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Empleados_EmpleadoTyperId",
                        column: x => x.EmpleadoTyperId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesTraducciones_Manwhas_ManwhaId",
                        column: x => x.ManwhaId,
                        principalTable: "Manwhas",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Donadores",
                columns: new[] { "Id", "Eliminado", "Nombre", "Pais", "Telefonos", "TotalDonado" },
                values: new object[,]
                {
                    { 1, false, "Damian", "Argentina", "123456789", 1000m },
                    { 2, false, "Lorena", "Chile", "987654321", 2000m },
                    { 3, false, "Carlos", "Cuba", "555666777", 3000m },
                    { 4, false, "Ana", "Brasil", "444555666", 2500m },
                    { 5, false, "Pedro", "Peru", "333444555", 1500m }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Correo", "Direccion", "Eliminado", "FechaNacimiento", "Nombre", "PuestoEmpleado", "Telefonos" },
                values: new object[,]
                {
                    { 1, "cesartorres21@gmail.com", "Calle Falsa 123", false, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cesar Torres", 3, "123456789" },
                    { 2, "agustinasan32@gmail.com", "Avenida Siempre Viva 742", false, new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agustina Santillan", 2, "987654321" },
                    { 3, "lucasdjo431@gmail.com", "Boulevard de los Sueños Rotos 101", false, new DateTime(1978, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucas Djovanni", 1, "555666777" },
                    { 4, "ananoseda320@gmail.com", "Ruta Nacional 19 Km 58", false, new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana Noseda", 0, "444555666" },
                    { 5, "pedrogimenez5463@gmail.com", "Calle del Sol 456", false, new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro Gimenez", 1, "333444555" }
                });

            migrationBuilder.InsertData(
                table: "Manwhas",
                columns: new[] { "Id", "Capitulos", "Eliminado", "ImagenUrl", "Nombre", "Sinopsis" },
                values: new object[,]
                {
                    { 1, 528m, false, "https://i.pinimg.com/564x/bb/3c/f7/bb3cf78908440b3b06898fb0fd9935da.jpg", "Lookism", "Daniel Park, o Park Hyung Suk, es un estudiante de secundaria impopular, gordo y feo que es intimidado y despreciado.\r\nDecidido a huir de sus problemas actuales y comenzar de nuevo, se muda a Seúl y asiste a una nueva escuela secundaria. Sin embargo, una noche durante las vacaciones, obtiene un nuevo cuerpo alto, musculoso y muy guapo. También se da cuenta de que al dormir en un cuerpo, despierta en el otro, y que no importa si lleva 24 horas seguidas despierto, siempre se siente descansado en el cuerpo que ocupa.\r\nMientras Daniel vive su vida con sus dos cuerpos, comienza a ver cuánto el mundo discrimina a las personas simplemente por ser poco atractivas o diferentes. De ahí el nombre de la obra \"Lookism\"." },
                    { 2, 165m, false, "https://i.pinimg.com/564x/43/cf/63/43cf6368ec1b14bf4b069601fbdfbdff.jpg", "Manager Kim", "Padre soltero, gerente de la compañía y ex miembro de operaciones encubiertas, el Sr. Kim vivió una vida normal hasta que su hija, Minji, desapareció. Después de descubrir que su hija podría estar muerta, el Sr. Kim se vuelve despiadado y busca información. Rescatará a su hija por cualquier medio necesario, incluso si eso significa destruir todo y a todos los que se interpongan en su camino." },
                    { 3, 163m, false, "https://i.pinimg.com/564x/18/7c/41/187c410a2f4d705ed87bc881843a35cf.jpg", "Quest Supremacy", "Kim SooHyun es un estudiante de secundaria normal que no es bueno para estudiar, pelear o ser atractivo. De repente, se enfrenta a una ventana de menú justo frente a sus ojos para acto seguido recibir los poderes de un [sistema] de juego de la nada, ¿cómo enfrentará nuestro héroe los desafíos que tiene por delante?" }
                });

            migrationBuilder.InsertData(
                table: "Origenes",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Coreano" },
                    { 2, false, "Chino" },
                    { 3, false, "Japones" }
                });

            migrationBuilder.InsertData(
                table: "Solicitudes",
                columns: new[] { "Id", "Eliminado", "Fecha", "ManwhaPedido" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prision Juvenil" },
                    { 2, false, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Breaker" },
                    { 3, false, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "To not Die" },
                    { 4, false, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The God of High School" }
                });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 22, 19, 20, 46, 347, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 22, 19, 20, 46, 347, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 22, 19, 20, 46, 347, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.InsertData(
                table: "Donaciones",
                columns: new[] { "Id", "DonadorId", "Eliminado", "Fecha", "FormaPago", "Iva", "Total" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2024, 11, 22, 19, 20, 46, 347, DateTimeKind.Local).AddTicks(6243), 4, 21m, 3000m },
                    { 2, 2, false, new DateTime(2024, 11, 22, 19, 20, 46, 347, DateTimeKind.Local).AddTicks(6246), 1, 10m, 5000m },
                    { 3, 1, false, new DateTime(2024, 11, 22, 19, 20, 46, 347, DateTimeKind.Local).AddTicks(6249), 2, 21m, 8000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_EmpleadoCleanerId",
                table: "DetallesTraducciones",
                column: "EmpleadoCleanerId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_EmpleadoEncargadoId",
                table: "DetallesTraducciones",
                column: "EmpleadoEncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_EmpleadoTraductorId",
                table: "DetallesTraducciones",
                column: "EmpleadoTraductorId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_EmpleadoTyperId",
                table: "DetallesTraducciones",
                column: "EmpleadoTyperId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesTraducciones_ManwhaId",
                table: "DetallesTraducciones",
                column: "ManwhaId");

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_DonadorId",
                table: "Donaciones",
                column: "DonadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesTraducciones");

            migrationBuilder.DropTable(
                name: "Donaciones");

            migrationBuilder.DropTable(
                name: "Donadores");

            migrationBuilder.DropTable(
                name: "Origenes");

            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Manwhas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 37, 31, 795, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 37, 31, 795, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 37, 31, 795, DateTimeKind.Local).AddTicks(406));
        }
    }
}
