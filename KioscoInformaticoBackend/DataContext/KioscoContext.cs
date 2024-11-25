using System;
using System.Collections.Generic;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace KioscoInformaticoServices.DataContext;



public partial class KioscoContext : DbContext
{
    public KioscoContext()
    {
    }

    public KioscoContext(DbContextOptions<KioscoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Detallescompra> Detallescompras { get; set; }

    public virtual DbSet<Detallesventa> Detallesventas { get; set; }

   

    public virtual DbSet<Localidad> Localidades { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedores { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Solicitud> Solicitudes { get; set; }

    public virtual DbSet<DetallesTraduccion> DetallesTraducciones { get; set; }

    public virtual DbSet<Donador> Donadores { get; set; }

    public virtual DbSet<Origen> Origenes { get; set; }

    public virtual DbSet<Manwha> Manwhas { get; set; }

    public virtual DbSet<Donacion> Donaciones { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
        var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

        string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");
        optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region datos semilla
        //carga de datos semilla Productos
        modelBuilder.Entity<Producto>().HasData(
            new Producto() { Id = 1, Nombre = "Coca Cola 2lts", Precio = 2650 },
            new Producto() { Id = 2, Nombre = "Sprite 2lts", Precio = 2450 },
            new Producto() { Id = 3, Nombre = "Fanta 2lts", Precio = 2550 }
            );
        //carga de datos semilla de localidades
        modelBuilder.Entity<Localidad>().HasData(
            new Localidad() { Id = 1, Nombre = "San Justo" },
            new Localidad() { Id = 2, Nombre = "Videla" },
            new Localidad() { Id = 3, Nombre = "Escalada" }
            );
        //carga de datos semilla de clientes
        modelBuilder.Entity<Cliente>().HasData(
        new Cliente
        {
            Id = 1,
            Nombre = "Juan Pérez",
            Direccion = "Calle Falsa 123",
            Telefonos = "123456789",
            FechaNacimiento = new DateTime(1985, 5, 15),
            LocalidadId = 1
        },
        new Cliente
        {
            Id = 2,
            Nombre = "María López",
            Direccion = "Avenida Siempre Viva 742",
            Telefonos = "987654321",
            FechaNacimiento = new DateTime(1990, 8, 25),
            LocalidadId = 2
        },
        new Cliente
        {
            Id = 3,
            Nombre = "Carlos García",
            Direccion = "Boulevard de los Sueños Rotos 101",
            Telefonos = "555666777",
            FechaNacimiento = new DateTime(1978, 2, 3),
            LocalidadId = 3
        },
        new Cliente
        {
            Id = 4,
            Nombre = "Ana Martínez",
            Direccion = "Ruta Nacional 19 Km 58",
            Telefonos = "444555666",
            FechaNacimiento = new DateTime(2000, 12, 12),
            LocalidadId = 1
        },
        new Cliente
        {
            Id = 5,
            Nombre = "Pedro Fernández",
            Direccion = "Calle del Sol 456",
            Telefonos = "333444555",
            FechaNacimiento = new DateTime(1995, 7, 30),
            LocalidadId = 2
        }
        );
        //Carga de datos semillas de ventas
        modelBuilder.Entity<Venta>().HasData(
            new Venta()
            {
                Id = 1,
                FormaPago = FormaDePagoEnum.Efectivo,
                Iva = 21m,
                Total = 3000m,
                ClienteId = 1,
                Fecha = DateTime.Now
            },
            new Venta() { Id = 2, FormaPago = FormaDePagoEnum.Tarjeta_Credito, Iva = 10, Total = 5000m, ClienteId = 2, Fecha = DateTime.Now },
            new Venta() { Id = 3, FormaPago = FormaDePagoEnum.Tarjeta_Debito, Iva = 21, Total = 8000m, ClienteId = 1, Fecha = DateTime.Now }
        );
        //carga de datos semilla de proveedores
        modelBuilder.Entity<Proveedor>().HasData(
        new Proveedor
        {
            Id = 1,
            Nombre = "Proveedor A",
            Direccion = "Calle 1",
            Telefonos = "111111111",
            Cbu = "0000003100010000000001",
            CondicionIva = CondicionIvaEnum.Responsable_Inscripto,
            LocalidadId = 1
        },
        new Proveedor
        {
            Id = 2,
            Nombre = "Proveedor B",
            Direccion = "Calle 2",
            Telefonos = "222222222",
            Cbu = "0000003100010000000002",
            CondicionIva = CondicionIvaEnum.Monotributista,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 3,
            Nombre = "Proveedor C",
            Direccion = "Calle 3",
            Telefonos = "333333333",
            Cbu = "0000003100010000000003",
            CondicionIva = CondicionIvaEnum.Consumidor_Final,
            LocalidadId = 3
        },
        new Proveedor
        {
            Id = 4,
            Nombre = "Proveedor D",
            Direccion = "Calle 4",
            Telefonos = "444444444",
            Cbu = "0000003100010000000004",
            CondicionIva = CondicionIvaEnum.Exento,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 5,
            Nombre = "Proveedor E",
            Direccion = "Calle 5",
            Telefonos = "555555555",
            Cbu = "0000003100010000000005",
            CondicionIva = CondicionIvaEnum.No_Responsable,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 6,
            Nombre = "Proveedor F",
            Direccion = "Calle 6",
            Telefonos = "666666666",
            Cbu = "0000003100010000000006",
            CondicionIva = CondicionIvaEnum.Responsable_NoInscripto,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 7,
            Nombre = "Proveedor G",
            Direccion = "Calle 7",
            Telefonos = "777777777",
            Cbu = "0000003100010000000007",
            CondicionIva = CondicionIvaEnum.Responsable_Inscripto,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 8,
            Nombre = "Proveedor H",
            Direccion = "Calle 8",
            Telefonos = "888888888",
            Cbu = "0000003100010000000008",
            CondicionIva = CondicionIvaEnum.Sujeto_NoCategorizado,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 9,
            Nombre = "Proveedor I",
            Direccion = "Calle 9",
            Telefonos = "999999999",
            Cbu = "0000003100010000000009",
            CondicionIva = CondicionIvaEnum.Monotributista,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 10,
            Nombre = "Proveedor J",
            Direccion = "Calle 10",
            Telefonos = "101010101",
            Cbu = "0000003100010000000010",
            CondicionIva = CondicionIvaEnum.Exento,
            LocalidadId = 2
        }
    );
        
        //carga de datos semilla de compras
        modelBuilder.Entity<Compra>().HasData(
            new Compra
            {
                Id = 1,
                FormaDePago = FormaDePagoEnum.Efectivo,
                Iva = CondicionIvaEnum.Responsable_NoInscripto,
                Total = 1000,
                Fecha = new DateTime(2021, 5, 15),
                ProveedorId = 1
            },
            new Compra
            {
                Id = 2,
                FormaDePago = FormaDePagoEnum.Tarjeta_Credito,
                Iva = CondicionIvaEnum.Responsable_Inscripto,
                Total = 2000,
                Fecha = new DateTime(2021, 5, 16),
                ProveedorId = 2
            },
            new Compra
            {
                Id = 3,
                FormaDePago = FormaDePagoEnum.Tarjeta_Debito,
                Iva = CondicionIvaEnum.Responsable_Inscripto,
                Total = 3000,
                Fecha = new DateTime(2021, 5, 17),
                ProveedorId = 3
            },
            new Compra
            {
                Id = 4,
                FormaDePago = FormaDePagoEnum.Efectivo,
                Iva = 0,
                Total = 4000,
                Fecha = new DateTime(2021, 5, 18),
               ProveedorId = 4
            }
        ) ;
        //carga de datos semilla de detalle compra
        modelBuilder.Entity<Detallescompra>().HasData(
            new Detallescompra { Id = 1, ProductosId = 1, PrecioUnitario = 2650, Cantidad = 1, CompraId = 1 },
            new Detallescompra { Id = 2, ProductosId = 2, PrecioUnitario = 2450, Cantidad = 2, CompraId = 2 },
            new Detallescompra { Id = 3, ProductosId = 3, PrecioUnitario = 2550, Cantidad = 1, CompraId = 3 }
            );

        //carga de datos semilla de detalle venta
        modelBuilder.Entity<Detallesventa>().HasData(
            new Detallesventa { Id = 1, VentaId = 1, ProductoId = 1, Cantidad = 1, PrecioUnitario = 2650 },
            new Detallesventa { Id = 2, VentaId = 2, ProductoId = 2, Cantidad = 2, PrecioUnitario = 2450 },
            new Detallesventa { Id = 3, VentaId = 3, ProductoId = 3, Cantidad = 1, PrecioUnitario = 2550 });

        #endregion

        #region datos semilla Scan
        //carga de datos semilla Productos
        modelBuilder.Entity<Manwha>().HasData(
            new Manwha()
            {
                Id = 1,
                Nombre = "Lookism",
                Capitulos = 528,
                Sinopsis = "Daniel Park, o Park Hyung Suk, es un estudiante de secundaria impopular, gordo y feo que es intimidado y despreciado.\r\nDecidido a huir de sus problemas actuales y comenzar de nuevo, se muda a Seúl y asiste a una nueva escuela secundaria. Sin embargo, una noche durante las vacaciones, obtiene un nuevo cuerpo alto, musculoso y muy guapo. También se da cuenta de que al dormir en un cuerpo, despierta en el otro, y que no importa si lleva 24 horas seguidas despierto, siempre se siente descansado en el cuerpo que ocupa.\r\nMientras Daniel vive su vida con sus dos cuerpos, comienza a ver cuánto el mundo discrimina a las personas simplemente por ser poco atractivas o diferentes. De ahí el nombre de la obra \"Lookism\".",
                ImagenUrl = "https://i.pinimg.com/564x/bb/3c/f7/bb3cf78908440b3b06898fb0fd9935da.jpg"
            },
            new Manwha()
            {
                Id = 2,
                Nombre = "Manager Kim",
                Capitulos = 165,
                Sinopsis = "Padre soltero, gerente de la compañía y ex miembro de operaciones encubiertas, el Sr. Kim vivió una vida normal hasta que su hija, Minji, desapareció. Después de descubrir que su hija podría estar muerta, el Sr. Kim se vuelve despiadado y busca información. Rescatará a su hija por cualquier medio necesario, incluso si eso significa destruir todo y a todos los que se interpongan en su camino.",
                ImagenUrl = "https://i.pinimg.com/564x/43/cf/63/43cf6368ec1b14bf4b069601fbdfbdff.jpg"
            },
            new Manwha()
            {
                Id = 3,
                Nombre = "Quest Supremacy",
                Capitulos = 163,
                Sinopsis = "Kim SooHyun es un estudiante de secundaria normal que no es bueno para estudiar, pelear o ser atractivo. De repente, se enfrenta a una ventana de menú justo frente a sus ojos para acto seguido recibir los poderes de un [sistema] de juego de la nada, ¿cómo enfrentará nuestro héroe los desafíos que tiene por delante?",
                ImagenUrl = "https://i.pinimg.com/564x/18/7c/41/187c410a2f4d705ed87bc881843a35cf.jpg"
            }
            );
        //carga de datos semilla de Origenes
        modelBuilder.Entity<Origen>().HasData(
            new Origen() { Id = 1, Nombre = "Coreano" },
            new Origen() { Id = 2, Nombre = "Chino" },
            new Origen() { Id = 3, Nombre = "Japones" }
            );
        //carga de datos semilla de Empleados
        modelBuilder.Entity<Empleado>().HasData(
        new Empleado
        {
            Id = 1,
            Nombre = "Cesar Torres",
            Direccion = "Calle Falsa 123",
            Telefonos = "123456789",
            PuestoEmpleado = PuestoEmpleadoEnum.Encargado,
            FechaNacimiento = new DateTime(1985, 5, 15),
            Correo = "cesartorres21@gmail.com"
        },
        new Empleado
        {
            Id = 2,
            Nombre = "Agustina Santillan",
            Direccion = "Avenida Siempre Viva 742",
            Telefonos = "987654321",
            PuestoEmpleado = PuestoEmpleadoEnum.Traductor,
            FechaNacimiento = new DateTime(1990, 8, 25),
            Correo = "agustinasan32@gmail.com"
        },
        new Empleado
        {
            Id = 3,
            Nombre = "Lucas Djovanni",
            Direccion = "Boulevard de los Sueños Rotos 101",
            Telefonos = "555666777",
            PuestoEmpleado = PuestoEmpleadoEnum.Typer,
            FechaNacimiento = new DateTime(1978, 2, 3),
            Correo = "lucasdjo431@gmail.com"
        },
        new Empleado
        {
            Id = 4,
            Nombre = "Ana Noseda",
            Direccion = "Ruta Nacional 19 Km 58",
            Telefonos = "444555666",
            PuestoEmpleado = PuestoEmpleadoEnum.Cleaner,
            FechaNacimiento = new DateTime(2000, 12, 12),
            Correo = "ananoseda320@gmail.com"
        },
        new Empleado
        {
            Id = 5,
            Nombre = "Pedro Gimenez",
            Direccion = "Calle del Sol 456",
            Telefonos = "333444555",
            PuestoEmpleado = PuestoEmpleadoEnum.Typer,
            FechaNacimiento = new DateTime(1995, 7, 30),
            Correo = "pedrogimenez5463@gmail.com"
        }
        );
        //carga de datos semilla de Donadores
        modelBuilder.Entity<Donador>().HasData(
        new Donador
        {
            Id = 1,
            Nombre = "Damian",
            Pais = "Argentina",
            Telefonos = "123456789",
            TotalDonado = 1000,
        },
        new Donador
        {
            Id = 2,
            Nombre = "Lorena",
            Pais = "Chile",
            Telefonos = "987654321",
            TotalDonado = 2000,
        },
        new Donador
        {
            Id = 3,
            Nombre = "Carlos",
            Pais = "Cuba",
            Telefonos = "555666777",
            TotalDonado = 3000,
        },
        new Donador
        {
            Id = 4,
            Nombre = "Ana",
            Pais = "Brasil",
            Telefonos = "444555666",
            TotalDonado = 2500,
        },
        new Donador
        {
            Id = 5,
            Nombre = "Pedro",
            Pais = "Peru",
            Telefonos = "333444555",
            TotalDonado = 1500,
        }

        );
        //Carga de datos semillas de Donaciones
        modelBuilder.Entity<Donacion>().HasData(
            new Donacion()
            {
                Id = 1,
                FormaPago = FormaDePagoEnum.Paypal,
                Iva = 21m,
                Total = 3000m,
                DonadorId = 1,
                Fecha = DateTime.Now
            },
            new Donacion() { Id = 2, FormaPago = FormaDePagoEnum.Tarjeta_Credito, Iva = 10, Total = 5000m, DonadorId = 2, Fecha = DateTime.Now },
            new Donacion() { Id = 3, FormaPago = FormaDePagoEnum.Tarjeta_Debito, Iva = 21, Total = 8000m, DonadorId = 1, Fecha = DateTime.Now }
        );

        //carga de datos semilla de Solicitudes
        modelBuilder.Entity<Solicitud>().HasData(
            new Solicitud
            {
                Id = 1,
                ManwhaPedido = "Prision Juvenil",
                Fecha = new DateTime(2021, 5, 15),
            },
            new Solicitud
            {
                Id = 2,
                ManwhaPedido = "The Breaker",
                Fecha = new DateTime(2021, 5, 16),
            },
            new Solicitud
            {
                Id = 3,
                ManwhaPedido = "To not Die",
                Fecha = new DateTime(2021, 5, 17),

            },
            new Solicitud
            {
                Id = 4,
                ManwhaPedido = "The God of High School",
                Fecha = new DateTime(2021, 5, 18),

            }
        );



        #endregion


        #region definición de filtros de eliminación
        // (este código no lo habilitamos todavía porque es cuando agregamos un campo Eliminado a las tablas y modificamos los
        // ApiControllers para que al mandar a eliminar solo cambien este campo y lo pongan en verdadero, esta configuración de
        // eliminación hace que el sistema ignore los registros que tengan el eliminado en verdadero, así que hace que en
        // apariencia y funcionalidad esté "eliminado", pero van a seguir estando ahí para que podamos observar las eliminaciones que hubo)
        modelBuilder.Entity<Cliente>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Compra>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Detallescompra>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Detallesventa>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Localidad>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Producto>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Proveedor>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Venta>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Empleado>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Solicitud>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<DetallesTraduccion>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Origen>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Manwha>().HasQueryFilter(m => !m.Eliminado);
        modelBuilder.Entity<Donacion>().HasQueryFilter(m => !m.Eliminado);

        #endregion
    }
   
}

