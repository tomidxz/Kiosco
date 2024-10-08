﻿using KioscoInformaticoServices.Interfaces;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ClientesView : Form
    {
        IClienteService clienteService = new ClienteService();
        ILocalidadService localidadService = new LocalidadService();
        BindingSource listaClientes = new BindingSource();
        List<Cliente> listaAFiltrar = new List<Cliente>();
        Cliente clienteCurrent;
        public ClientesView()
        {
            InitializeComponent();
            dataGridClientes.DataSource = listaClientes;
            CargarGrilla();
            CargarCombo();
        }

        private async Task CargarCombo()
        {
            cboLocalidad.DataSource = await localidadService.GetAllAsync();
            cboLocalidad.DisplayMember = "Nombre";
            cboLocalidad.ValueMember = "Id";


        }

        private async Task CargarGrilla()
        {
            listaClientes.DataSource = await clienteService.GetAllAsync(null);
            listaAFiltrar = (List<Cliente>)listaClientes.DataSource;
            dataGridClientes.Columns[5].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clienteCurrent != null)
            {
                clienteCurrent.Nombre = txtNombre.Text;
                clienteCurrent.Direccion = txtDireccion.Text;
                clienteCurrent.Telefonos = txtTelefono.Text;
                clienteCurrent.LocalidadId= (int)cboLocalidad.SelectedValue;
                clienteCurrent.FechaNacimiento=dateTimeFechaNacimiento.Value;
                await clienteService.UpdateAsync(clienteCurrent);
                clienteCurrent = null;
            }
            else
            {
                Cliente cliente = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefono.Text,
                    LocalidadId = (int)cboLocalidad.SelectedValue,
                    FechaNacimiento = dateTimeFechaNacimiento.Value
                };
                await clienteService.AddAsync(cliente);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            tabControlLista.SelectedTab = tabPageLista;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)listaClientes.Current;
            txtNombre.Text = clienteCurrent.Nombre;
            txtDireccion.Text = clienteCurrent.Direccion;
            txtTelefono.Text = clienteCurrent.Telefonos;
            cboLocalidad.SelectedValue = clienteCurrent.LocalidadId;
            dateTimeFechaNacimiento.Value= clienteCurrent.FechaNacimiento;
            tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)listaClientes.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar el cliente {clienteCurrent.Nombre}?",
                                   "Eliminar cliente",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await clienteService.DeleteAsync(clienteCurrent.Id);
                clienteCurrent = null;
                await CargarGrilla();
            }
        }

        private async void FiltrarClientes()
        {
            var clientesFiltrados = listaAFiltrar.Where(p => p.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            listaClientes.DataSource = clientesFiltrados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cboLocalidad.SelectedIndex = 0;
            tabControlLista.SelectedTab = tabPageLista;
        }
    }
}
