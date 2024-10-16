using KioscoInformaticoServices.Interfaces;
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
    public partial class ClientesViewReport : Form
    {
        ReportViewer reporte;
        IClienteService clienteService = new ClienteService();
        public ClientesViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        private async void ClientesViewReport_Load(object sender, EventArgs e)
        {
              reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Report.ClientesReport.rdlc";
                var clientes = await clienteService.GetAllAsync();
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSClientes", clientes));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                //definimos zoom al 100%
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.ZoomPercent = 100;
                reporte.RefreshReport();
            }
        
    }
}
