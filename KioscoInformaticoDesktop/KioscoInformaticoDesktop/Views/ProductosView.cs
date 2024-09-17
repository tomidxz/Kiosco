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
    public partial class ProductosView : Form
    {
        IGenericService<Producto> productoService = new GenericService<Producto>();
        BindingSource listaProductos = new BindingSource();
        List<Producto> listaAFiltrada = new List<Producto>();
        Producto productoCurrent;

        public ProductosView()
        {
            InitializeComponent();
            DataGridProductos.DataSource = listaProductos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            {
                listaProductos.DataSource = await productoService.GetAllAsync();
                listaAFiltrada = (List<Producto>)listaProductos.DataSource;
            }
        }







        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {

                MessageBox.Show("Debe ingresar un nombre de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (productoCurrent != null)
            {
                productoCurrent.Nombre = txtNombre.Text;
                productoCurrent.Precio = numericPrecio.Value;
                await productoService.UpdateAsync(productoCurrent);
                productoCurrent = null;

            }
            else
            {
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = numericPrecio.Value
                };

                await productoService.AddAsync(producto);
            }

            await CargarGrilla();
            txtNombre.Text = string.Empty;
            numericPrecio.Value = 0;
            tabControl.SelectTab(tabLista);
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)listaProductos.Current;
            txtNombre.Text = productoCurrent.Nombre;
            numericPrecio.Value = productoCurrent.Precio;


            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var producto = (Producto)listaProductos.Current;
                await productoService.DeleteAsync(producto.Id);
                CargarGrilla();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            var productosFiltrados = listaAFiltrada.Where(p => p.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            listaProductos.DataSource = productosFiltrados;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }
    }
}

