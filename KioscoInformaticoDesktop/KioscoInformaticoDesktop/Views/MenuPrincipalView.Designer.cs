namespace KioscoInformaticoDesktop
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
            Bases = new FontAwesome.Sharp.IconMenuItem();
            ItemMenuLocalidades = new FontAwesome.Sharp.IconMenuItem();
            Salir = new FontAwesome.Sharp.IconMenuItem();
            ItemMEnuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, Bases, Salir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 30;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(95, 34);
            iconMenuItem1.Text = "Principal";
            // 
            // Bases
            // 
            Bases.DropDownItems.AddRange(new ToolStripItem[] { ItemMenuLocalidades, iconMenuItem2 });
            Bases.IconChar = FontAwesome.Sharp.IconChar.Database;
            Bases.IconColor = Color.Black;
            Bases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Bases.IconSize = 30;
            Bases.ImageScaling = ToolStripItemImageScaling.None;
            Bases.Name = "Bases";
            Bases.Size = new Size(78, 34);
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
            ItemMenuLocalidades.Size = new Size(194, 36);
            ItemMenuLocalidades.Text = "Localidades";
            ItemMenuLocalidades.Click += ItemMenuLocalidades_Click;
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
            Salir.Size = new Size(71, 34);
            Salir.Text = "Salir";
            // 
            // ItemMEnuSalirDelSistema
            // 
            ItemMEnuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            ItemMEnuSalirDelSistema.IconColor = Color.Black;
            ItemMEnuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ItemMEnuSalirDelSistema.IconSize = 30;
            ItemMEnuSalirDelSistema.ImageScaling = ToolStripItemImageScaling.None;
            ItemMEnuSalirDelSistema.Name = "ItemMEnuSalirDelSistema";
            ItemMEnuSalirDelSistema.Size = new Size(172, 36);
            ItemMEnuSalirDelSistema.Text = "Salir del sistema";
            ItemMEnuSalirDelSistema.Click += ItemMEnuSalirDelSistema_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.SquareVirus;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(194, 36);
            iconMenuItem2.Text = "Productos";
            iconMenuItem2.Click += iconMenuItem2_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kiosco Informático Desktop";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
