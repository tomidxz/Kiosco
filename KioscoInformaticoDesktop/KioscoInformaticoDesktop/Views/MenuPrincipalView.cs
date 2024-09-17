using KioscoInformaticoDesktop.Views;

namespace KioscoInformaticoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void ItemMEnuSalirDelSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemMenuLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesView localidadesView = new LocalidadesView();
            localidadesView.Show();
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.Show();
        }
    }
}
