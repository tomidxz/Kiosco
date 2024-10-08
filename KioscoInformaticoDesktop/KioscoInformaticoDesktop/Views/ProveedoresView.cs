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
using System.Windows.Controls;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ProveedoresView : Form
    {
        IProveedorService proveedorService = new ProveedorService();
        ILocalidadService localidadService = new LocalidadService();
        BindingSource listaProveedores = new BindingSource();
        List<Proveedor> listaAFiltrar = new List<Proveedor>();
        Proveedor proveedorCurrent;
        public ProveedoresView()
        {
            InitializeComponent();
            dataGridProveedores.DataSource = listaProveedores;
            CargarGrilla();
            CargarCombo();
            cboCondicionIva.DataSource = Enum.GetValues(typeof(CondicionIvaEnum));
        }

        private async Task CargarCombo()
        {
            cboLocalidad.DataSource = await localidadService.GetAllAsync();
            cboLocalidad.DisplayMember = "Nombre";
            cboLocalidad.ValueMember = "Id";
        }

        private async Task CargarGrilla()
        {
            listaProveedores.DataSource = await proveedorService.GetAllAsync(null);
            listaAFiltrar = (List<Proveedor>)listaProveedores.DataSource;
            dataGridProveedores.Columns["localidadId"].Visible = false;
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

            if (proveedorCurrent != null)
            {
                proveedorCurrent.Nombre = txtNombre.Text;
                proveedorCurrent.Direccion = txtDireccion.Text;
                proveedorCurrent.Telefonos = txtTelefono.Text;
                proveedorCurrent.LocalidadId = (int)cboLocalidad.SelectedValue;
                proveedorCurrent.Cbu = txtCbu.Text;
                proveedorCurrent.CondicionIva= (CondicionIvaEnum)cboCondicionIva.SelectedValue;
                await proveedorService.UpdateAsync(proveedorCurrent);
                proveedorCurrent = null;
            }
            else
            {
                Proveedor proveedor = new Proveedor()
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefono.Text,
                    LocalidadId = (int)cboLocalidad.SelectedValue,
                    CondicionIva = (CondicionIvaEnum) cboCondicionIva.SelectedItem,
                    Cbu = txtCbu.Text
                };
                await proveedorService.AddAsync(proveedor);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCbu.Text = string.Empty;
            tabControlLista.SelectedTab = tabPageLista;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)listaProveedores.Current;
            txtNombre.Text = proveedorCurrent.Nombre;
            txtDireccion.Text = proveedorCurrent.Direccion;
            txtTelefono.Text = proveedorCurrent.Telefonos;
            cboLocalidad.SelectedValue = proveedorCurrent.LocalidadId;
            txtCbu.Text = proveedorCurrent.Cbu;
            cboCondicionIva.SelectedItem = proveedorCurrent.CondicionIva;
            tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = (Proveedor)listaProveedores.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar el cliente {proveedorCurrent.Nombre}?",
                                   "Eliminar cliente",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await proveedorService.DeleteAsync(proveedorCurrent.Id);
                proveedorCurrent = null;
                await CargarGrilla();
            }
        }

        private async void FiltrarProveedores()
        {
            var proveedoresFiltrados = listaAFiltrar.Where(p => p.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            listaProveedores.DataSource = proveedoresFiltrados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            proveedorCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cboLocalidad.SelectedIndex = 0;
            tabControlLista.SelectedTab = tabPageLista;
        }

    }
}
