﻿namespace KioscoInformaticoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        //masdasdasdasdasd
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            Bases = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            Clientes = new FontAwesome.Sharp.IconMenuItem();
            Proveedores = new FontAwesome.Sharp.IconMenuItem();
            listadosToolStripMenuItem = new ToolStripMenuItem();
            localidadesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            facturasDeVentasToolStripMenuItem = new ToolStripMenuItem();
            Salir = new FontAwesome.Sharp.IconMenuItem();
            ItemMEnuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            iconToolHistoricoVentas = new FontAwesome.Sharp.IconToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, Bases, listadosToolStripMenuItem, Salir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, comprasToolStripMenuItem });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 30;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(110, 34);
            iconMenuItem1.Text = "Principal";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(151, 26);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(151, 26);
            comprasToolStripMenuItem.Text = "Compras";
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            // 
            // Bases
            // 
            Bases.DropDownItems.AddRange(new ToolStripItem[] { ItemMenuLocalidades, iconMenuItem2, Clientes, Proveedores });
            Bases.IconChar = FontAwesome.Sharp.IconChar.Database;
            Bases.IconColor = Color.Black;
            Bases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Bases.IconSize = 30;
            Bases.ImageScaling = ToolStripItemImageScaling.None;
            Bases.Name = "Bases";
            Bases.Size = new Size(90, 34);
            Bases.Text = "Bases";
            // 
            // ItemMenuLocalidades
            // 
            ItemMenuLocalidades.IconChar = FontAwesome.Sharp.IconChar.Location;
            ItemMenuLocalidades.IconColor = Color.Black;
            ItemMenuLocalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMenuLocalidades.IconSize = 30;
            ItemMenuLocalidades.ImageScaling = ToolStripItemImageScaling.None;
            ItemMenuLocalidades.Name = "ItemMenuLocalidades";
            ItemMenuLocalidades.Size = new Size(184, 36);
            ItemMenuLocalidades.Text = "Localidades";
            ItemMenuLocalidades.Click += ItemMenuLocalidades_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.SquareVirus;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(184, 36);
            iconMenuItem2.Text = "Productos";
            iconMenuItem2.Click += iconMenuItem2_Click;
            // 
            // Clientes
            // 
            Clientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            Clientes.IconColor = Color.Black;
            Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(184, 36);
            Clientes.Text = "Clientes";
            Clientes.Click += Clientes_Click;
            // 
            // Proveedores
            // 
            Proveedores.IconChar = FontAwesome.Sharp.IconChar.Plane;
            Proveedores.IconColor = Color.Black;
            Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Proveedores.Name = "Proveedores";
            Proveedores.Size = new Size(184, 36);
            Proveedores.Text = "Proveedores";
            Proveedores.Click += Proveedores_Click;
            // 
            // listadosToolStripMenuItem
            // 
            listadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localidadesToolStripMenuItem, clientesToolStripMenuItem, facturasDeVentasToolStripMenuItem });
            listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            listadosToolStripMenuItem.Size = new Size(77, 34);
            listadosToolStripMenuItem.Text = "Listados";
            // 
            // localidadesToolStripMenuItem
            // 
            localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            localidadesToolStripMenuItem.Size = new Size(213, 26);
            localidadesToolStripMenuItem.Text = "Localidades";
            localidadesToolStripMenuItem.Click += localidadesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(213, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // facturasDeVentasToolStripMenuItem
            // 
            facturasDeVentasToolStripMenuItem.Name = "facturasDeVentasToolStripMenuItem";
            facturasDeVentasToolStripMenuItem.Size = new Size(213, 26);
            facturasDeVentasToolStripMenuItem.Text = "Facturas de Ventas";
            facturasDeVentasToolStripMenuItem.Click += facturasDeVentasToolStripMenuItem_Click;
            // 
            // Salir
            // 
            Salir.DropDownItems.AddRange(new ToolStripItem[] { ItemMEnuSalirDelSistema });
            Salir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            Salir.IconColor = Color.Black;
            Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Salir.IconSize = 30;
            Salir.ImageScaling = ToolStripItemImageScaling.None;
            Salir.Name = "Salir";
            Salir.Size = new Size(82, 34);
            Salir.Text = "Salir";
            Salir.Click += Salir_Click;
            // 
            // ItemMEnuSalirDelSistema
            // 
            ItemMEnuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            ItemMEnuSalirDelSistema.IconColor = Color.Black;
            ItemMEnuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMEnuSalirDelSistema.IconSize = 30;
            ItemMEnuSalirDelSistema.ImageScaling = ToolStripItemImageScaling.None;
            ItemMEnuSalirDelSistema.Name = "ItemMEnuSalirDelSistema";
            ItemMEnuSalirDelSistema.Size = new Size(234, 36);
            ItemMEnuSalirDelSistema.Text = "Salir del sistema";
            ItemMEnuSalirDelSistema.Click += ItemMEnuSalirDelSistema_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconToolHistoricoVentas });
            toolStrip1.Location = new Point(0, 40);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 70);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconToolHistoricoVentas
            // 
            iconToolHistoricoVentas.Font = new Font("Segoe UI", 7F);
            iconToolHistoricoVentas.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconToolHistoricoVentas.IconColor = Color.Black;
            iconToolHistoricoVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolHistoricoVentas.ImageScaling = ToolStripItemImageScaling.None;
            iconToolHistoricoVentas.ImageTransparentColor = Color.Magenta;
            iconToolHistoricoVentas.Name = "iconToolHistoricoVentas";
            iconToolHistoricoVentas.Size = new Size(96, 67);
            iconToolHistoricoVentas.Text = "Historico Ventas";
            iconToolHistoricoVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolHistoricoVentas.Click += iconToolHistoricoVentas_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 451);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kiosco Informático Desktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem Salir;
        private FontAwesome.Sharp.IconMenuItem ItemMEnuSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem Bases;
        private FontAwesome.Sharp.IconMenuItem ItemMenuLocalidades;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem Clientes;
        private FontAwesome.Sharp.IconMenuItem Proveedores;
        private ToolStripMenuItem listadosToolStripMenuItem;
        private ToolStripMenuItem localidadesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem facturasDeVentasToolStripMenuItem;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton iconToolHistoricoVentas;
        private ToolStripMenuItem comprasToolStripMenuItem;
    }
}
