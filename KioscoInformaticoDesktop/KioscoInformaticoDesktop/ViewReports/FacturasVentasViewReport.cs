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
    public partial class FacturasVentasViewReport : Form
    {
        ReportViewer reporte;
        private Venta? nuevaventa;

        public FacturasVentasViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        public FacturasVentasViewReport(Venta? nuevaventa)
        {
            this.nuevaventa = nuevaventa;
            InitializeComponent();
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
            this.nuevaventa = nuevaventa;
        }

        private void FacturasVentasViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Report.FacturaVentaReport.rdlc";
            List<object> venta = new List<object> { new { Id = nuevaventa.Id, Fecha = nuevaventa.Fecha, ClienteNombre = nuevaventa.Cliente.Nombre, Total = nuevaventa.Total, Iva = nuevaventa.Iva, FormaPago = nuevaventa.FormaPago.ToString() } };



            var detalleVenta = nuevaventa.DetallesVenta.Select(detalle => new { ProductoNombre = detalle.Producto.Nombre, PrecioUnitario = detalle.PrecioUnitario, Cantidad = detalle.Cantidad, Subtotal = detalle.SubTotal });


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", venta));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesVenta", detalleVenta));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
