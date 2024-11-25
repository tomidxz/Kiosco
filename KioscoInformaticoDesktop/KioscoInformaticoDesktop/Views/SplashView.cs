﻿using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
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
    public partial class SplashView : Form
    {
        bool dataReady = false;
        bool printReady = false;
        public SplashView()
        {
            InitializeComponent();
        }

        private async void SplashView_Activated(object sender, EventArgs e)
        {
            var conectarDbTask = ConectarConDb();
            var imprimirReporteTask = ImprimirReporte();
            await Task.WhenAll(conectarDbTask, imprimirReporteTask);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 98)
                progressBar.Value += 4;
            if (dataReady && printReady)
            {
                timer.Enabled = false;
                this.Visible = false;
                var frmMenuPrincipal = new MenuPrincipalView();
                frmMenuPrincipal.ShowDialog();
                this.Close();
            }
        }

        private async Task ImprimirReporte()
        {
            await Task.Run(() =>
            {
                ReportViewer reporte = new ReportViewer();
                reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Report.LocalidadesReport.rdlc";
                var localidades = new List<Localidad> { new Localidad() { Id = 1, Nombre = "San Justo" } };
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSLocalidades", localidades));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                //definimos zoom al 100%
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.ZoomPercent = 100;
                reporte.RefreshReport();
                printReady = true;
            });

        }

        private async Task ConectarConDb()
        {
            await Task.Run(async () =>
            {
                ClienteService clienteService = new ClienteService();
                var clientes = await clienteService.GetAllAsync();
                dataReady = true;
            });
        }
    }
}
