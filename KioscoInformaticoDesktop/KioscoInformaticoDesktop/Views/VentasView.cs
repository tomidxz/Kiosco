using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class VentasView : Form
    {
        ClienteService clienteService = new ClienteService();
        ProductoService productoService = new ProductoService();
        IGenericService<Venta> ventaService = new GenericService<Venta>();

        Venta venta = new Venta();

        public VentasView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            #region carga de combos
            //Stopwatch reloj = new Stopwatch();
            //reloj.Start();

            await Task.WhenAll(

                Task.Run(async () => comboClientes.DataSource = await clienteService.GetAllAsync()),
                Task.Run(async () => comboProductos.DataSource = await productoService.GetAllAsync())
                );


            comboFormasDePago.DisplayMember = "Nombre";
            comboFormasDePago.ValueMember = "Id";



            comboProductos.DisplayMember = "Nombre";
            comboProductos.ValueMember = "Id";
            comboProductos.SelectedIndex = -1;

            comboClientes.DisplayMember = "Nombre";
            comboClientes.ValueMember = "Id";
            comboClientes.SelectedIndex = -1;

            //reloj.Stop();
            //Debug.Print($"tiempo de carga de combos:{reloj.ElapsedMilliseconds}ms");

            comboFormasDePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));

            #endregion
            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            dataGridDetallesVenta.DataSource = venta.DetallesVenta.ToList();

        }


        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            //haceme una multiplicacion de numericSubtotal por numericCantidad
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void comboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProductos.SelectedIndex != -1)
            {
                Producto producto = (Producto)comboProductos.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
            btnAgregar.Enabled = comboProductos.SelectedIndex != -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleVenta = new Detallesventa
            {
                Producto = (Producto)comboProductos.SelectedItem,
                ProductoId = (int)comboProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value

            };
            venta.DetallesVenta.Add(detalleVenta);
            dataGridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            comboProductos.SelectedIndex = -1;
            comboProductos.Focus();
            AcualizarTotalFactura();

        }

        private void AcualizarTotalFactura()
        {
            numericTotal.Value = venta.DetallesVenta.Sum(detalleventa => detalleventa.Cantidad * detalleventa.PrecioUnitario);
        }

        private void dataGridDetallesVenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridDetallesVenta.OcultarColumnas(new string[] { "Id", "VentaId", "ProductoId", "Eliminado" });
            btnQuitar.Enabled = dataGridDetallesVenta.Rows.Count > 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridDetallesVenta.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un detalle de venta");
                return;
            }

            var detalleVenta = (Detallesventa)dataGridDetallesVenta.CurrentRow.DataBoundItem;
            venta.DetallesVenta.Remove(detalleVenta);
            dataGridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            AcualizarTotalFactura();


        }

        private async void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            ////cargamos los datos de la venta
            //Venta ventaTemp = new Venta();
            venta.ClienteId = (int)comboClientes.SelectedValue;
            venta.Cliente = (Cliente)comboClientes.SelectedItem;
            venta.FormaPago = (FormaDePagoEnum)comboFormasDePago.SelectedValue;
            venta.Fecha = DateTime.Now;

            venta.Total = numericTotal.Value;
            venta.Iva = venta.Total * 0.21m;
            var nuevaVenta = await ventaService.AddAsync(venta);
            var facturaVentaViewReport = new FacturasVentasViewReport(nuevaVenta);
            facturaVentaViewReport.ShowDialog();


        }
    }
}
