using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.ViewReports
{
    public partial class FacturasComprasViewReport : Form
    {
        ReportViewer reporte;
        private Compra? nuevacompra;

        public FacturasComprasViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        public FacturasComprasViewReport(Venta? nuevaventa)
        {
            this.nuevacompra = nuevacompra;
            InitializeComponent();
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
            this.nuevacompra = nuevacompra;
        }

        private void FacturasVentasViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Report.FacturasComprasReport.rdlc";
            List<object> compra = new List<object> { new { Id = nuevacompra.Id, Fecha = nuevacompra.Fecha, ClienteNombre = nuevacompra.Proveedor.Nombre, Total = nuevacompra.Total, Iva = nuevacompra.Iva, FormaPago = nuevacompra.FormaDePago.ToString() } };



            var detallescompra = nuevacompra.DetalleCompra.Select(detalle => new { ProductoNombre = detalle.Producto.Nombre, PrecioUnitario = detalle.PrecioUnitario, Cantidad = detalle.Cantidad, Subtotal = detalle.SubTotal });


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCompras", compra));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesVenta", detallescompra));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
