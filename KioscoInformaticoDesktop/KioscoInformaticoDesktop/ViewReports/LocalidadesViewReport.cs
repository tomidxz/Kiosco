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
    public partial class LocalidadesViewReport : Form
    {
        ReportViewer reporte;
        ILocalidadService localidadService = new LocalidadService();
        public LocalidadesViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        private async void LocalidadesViewReport_Load_1(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Report.LocalidadesReport.rdlc";
            var localidades = await localidadService.GetAllAsync();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSLocalidades", localidades));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
