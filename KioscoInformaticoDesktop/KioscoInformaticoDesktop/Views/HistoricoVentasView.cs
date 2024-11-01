﻿using KioscoInformaticoDesktop.ExtensionMethods;
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
    public partial class HistoricoVentasView : Form
    {
        GenericService<Venta> _ventaService = new GenericService<Venta>();
        List<Venta> ventas = new List<Venta>();
        public HistoricoVentasView()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            ventas = await _ventaService.GetAllAsync();
            DisplayDataGrid();
            CalculeTotal(); 

        }

        private void CalculeTotal()
        {
            if (checkFiltro.Checked)
           {
                numericTotal.Value = ventas.Where(venta => venta.Fecha >= dateTimeDesde.Value &&
                                                             venta.Fecha <= dateTimeHasta.Value).Sum(venta => venta.Total);
            }
            else
            {
                numericTotal.Value = ventas.Sum(venta => venta.Total);
            }
        }

        private void DisplayDataGrid()
        { 
            dataGridVentas.DataSource = ventas;
            dataGridVentas.OcultarColumnas(new string[] { "Id", "Eliminado", "ClienteId", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyy";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void checkFiltro_CheckedChanged(object sender, EventArgs e)
        {
            panelFiltrado.Enabled = checkFiltro.Checked;
            if (checkFiltro.Checked)
            {
                dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateTimeHasta.Value = DateTime.Now;

                DisplayDataGridFilter();
                CalculeTotal();
            }
            else
            {
                DisplayDataGrid();
            }
        }

        private void DisplayDataGridFilter()
        {
            dataGridVentas.DataSource = ventas.Where(venta => venta.Fecha >= dateTimeDesde.Value &&
                                                            venta.Fecha <= dateTimeHasta.Value).ToList();
            dataGridVentas.OcultarColumnas(new string[] { "Id", "Eliminado", "ClienteId", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyy";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DisplayDataGridFilter();
            CalculeTotal();
        }
    }
}
