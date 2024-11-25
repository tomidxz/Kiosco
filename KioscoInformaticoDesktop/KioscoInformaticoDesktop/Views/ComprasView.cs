using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ComprasView : Form
    {
        ProveedorService prooveedorService = new ProveedorService();
        ProductoService productoService = new ProductoService();
        IGenericService<Compra> compraService = new GenericService<Compra>();

        Compra compra = new Compra();
        public ComprasView()
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

                Task.Run(async () => comboProveedor.DataSource = await prooveedorService.GetAllAsync()),
                Task.Run(async () => comboProductos.DataSource = await productoService.GetAllAsync())
                );


            comboFormasDePago.DisplayMember = "Nombre";
            comboFormasDePago.ValueMember = "Id";



            comboProductos.DisplayMember = "Nombre";
            comboProductos.ValueMember = "Id";
            comboProductos.SelectedIndex = -1;

            comboProveedor.DisplayMember = "Nombre";
            comboProveedor.ValueMember = "Id";
            comboProveedor.SelectedIndex = -1;

            //reloj.Stop();
            //Debug.Print($"tiempo de carga de combos:{reloj.ElapsedMilliseconds}ms");

            comboFormasDePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));

            #endregion
            numericPrecioCom.Value = 0;
            numericCantidadCom.Value = 1;
            dataGridDetallesCompra.DataSource = compra.DetalleCompra.ToList();
        }

        private void numericPrecioCom_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotalCom.Value = numericPrecioCom.Value * numericCantidadCom.Value;
        }

        private void numericCantidadCom_ValueChanged_1(object sender, EventArgs e)
        {
            //haceme una multiplicacion de numericSubtotal por numericCantidad
            numericSubtotalCom.Value = numericPrecioCom.Value * numericCantidadCom.Value;
        }

        private void comboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProductos.SelectedIndex != -1)
            {
                Producto producto = (Producto)comboProductos.SelectedItem;
                numericPrecioCom.Value = producto.Precio;
            }
            btnAdd.Enabled = comboProductos.SelectedIndex != -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var detalleCompra = new Detallescompra
            {
                Producto = (Producto)comboProductos.SelectedItem,
                ProductosId = (int)comboProductos.SelectedValue,
                Cantidad = (int)numericCantidadCom.Value,
                PrecioUnitario = numericPrecioCom.Value
            };
            compra.DetalleCompra.Add(detalleCompra);
            dataGridDetallesCompra.DataSource = compra.DetalleCompra.ToList();
            comboProductos.SelectedIndex = -1;
            comboProductos.Focus();
            ActualizarFactura();
        }

        private void ActualizarFactura()
        {
            numericTotalCom.Value = compra.DetalleCompra.Sum(DetalleCompra => DetalleCompra.Cantidad * DetalleCompra.PrecioUnitario);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridDetallesCompra.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un detalle de compra");
                return;
            }
            var detalleCompra = (Detallescompra)dataGridDetallesCompra.CurrentRow.DataBoundItem;
            compra.DetalleCompra.Remove(detalleCompra);
            dataGridDetallesCompra.DataSource = compra.DetalleCompra.ToList();
            ActualizarFactura();
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            compra.ProveedorId = (int)comboProveedor.SelectedValue;
            compra.Proveedor = (Proveedor)comboProveedor.SelectedItem;
            compra.FormaDePago = (FormaDePagoEnum)comboFormasDePago.SelectedValue;
            compra.Fecha = DateTime.Now;

            compra.Total = numericTotalCom.Value;
            compra.Ivas = compra.Total * 0.21m;
            var nuevaCompra = await compraService.AddAsync(compra);

        }

        
    }
}
