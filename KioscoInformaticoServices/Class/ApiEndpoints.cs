using KioscoInformaticoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoServices.Class
{
    public static class ApiEndpoints
    {
        public static string Cliente { get; set; } = "clientes";
        public static string Compra { get; set; } = "Compras";
        public static string DetallesCompra { get; set; } = "DetallesCompras";
        public static string DetallesVenta { get; set; } = "DetallesVentas";
        public static string Localidad { get; set; } = "Localidades";
        public static string Producto { get; set; } = "Productos";
        public static string Proveedor { get; set; } = "Proveedores";
        public static string Venta { get; set; } = "Ventas";
        




        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Cliente) => Cliente,
                nameof(Compra) => Compra,
                nameof(DetallesCompra) => DetallesCompra,
                nameof(DetallesVenta) => DetallesVenta,
                nameof(Localidad) =>Localidad ,
                nameof(Producto) =>Producto ,
                nameof(Proveedor) => Proveedor,
                nameof(Venta) => Venta,


                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
