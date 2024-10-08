namespace KioscoInformaticoDesktop.Views
{
    partial class ProveedoresView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            tabControlLista = new TabControl();
            tabPageLista = new TabPage();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgreg = new FontAwesome.Sharp.IconButton();
            dataGridProveedores = new DataGridView();
            txtFiltro = new TextBox();
            label4 = new Label();
            tabPageAgregarEditar = new TabPage();
            label8 = new Label();
            txtCbu = new TextBox();
            label7 = new Label();
            cboLocalidad = new ComboBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            cboCondicionIva = new ComboBox();
            panel1.SuspendLayout();
            tabControlLista.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProveedores).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 84);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 0;
            label1.Text = "Proveedores";
            // 
            // tabControlLista
            // 
            tabControlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlLista.Controls.Add(tabPageLista);
            tabControlLista.Controls.Add(tabPageAgregarEditar);
            tabControlLista.Location = new Point(2, 91);
            tabControlLista.Margin = new Padding(3, 4, 3, 4);
            tabControlLista.Name = "tabControlLista";
            tabControlLista.SelectedIndex = 0;
            tabControlLista.Size = new Size(911, 509);
            tabControlLista.TabIndex = 2;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnAgreg);
            tabPageLista.Controls.Add(dataGridProveedores);
            tabPageLista.Controls.Add(txtFiltro);
            tabPageLista.Controls.Add(label4);
            tabPageLista.Location = new Point(4, 29);
            tabPageLista.Margin = new Padding(3, 4, 3, 4);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3, 4, 3, 4);
            tabPageLista.Size = new Size(903, 476);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 35;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(757, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(123, 44);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 35;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(757, 252);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 43);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.IconSize = 35;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(755, 188);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 40);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "Editar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgreg
            // 
            btnAgreg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgreg.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgreg.IconColor = Color.Black;
            btnAgreg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgreg.IconSize = 35;
            btnAgreg.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgreg.Location = new Point(755, 116);
            btnAgreg.Name = "btnAgreg";
            btnAgreg.Size = new Size(125, 46);
            btnAgreg.TabIndex = 27;
            btnAgreg.Text = "Agregar";
            btnAgreg.UseVisualStyleBackColor = true;
            btnAgreg.Click += btnAgregar_Click;
            // 
            // dataGridProveedores
            // 
            dataGridProveedores.AllowUserToAddRows = false;
            dataGridProveedores.AllowUserToDeleteRows = false;
            dataGridProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridProveedores.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridProveedores.Location = new Point(0, 64);
            dataGridProveedores.Name = "dataGridProveedores";
            dataGridProveedores.ReadOnly = true;
            dataGridProveedores.RowHeadersWidth = 51;
            dataGridProveedores.Size = new Size(720, 554);
            dataGridProveedores.TabIndex = 26;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(69, 16);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(651, 27);
            txtFiltro.TabIndex = 25;
            txtFiltro.TextChanged += txtBuscar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 19);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 24;
            label4.Text = "Buscar:";
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(cboCondicionIva);
            tabPageAgregarEditar.Controls.Add(label8);
            tabPageAgregarEditar.Controls.Add(txtCbu);
            tabPageAgregarEditar.Controls.Add(label7);
            tabPageAgregarEditar.Controls.Add(cboLocalidad);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(txtTelefono);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Margin = new Padding(3, 4, 3, 4);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3, 4, 3, 4);
            tabPageAgregarEditar.Size = new Size(903, 476);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(261, 349);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 27;
            label8.Text = "Condicion Iva:";
            // 
            // txtCbu
            // 
            txtCbu.Location = new Point(439, 285);
            txtCbu.Name = "txtCbu";
            txtCbu.Size = new Size(260, 27);
            txtCbu.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(261, 292);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 25;
            label7.Text = "Cbu:";
            // 
            // cboLocalidad
            // 
            cboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(439, 232);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(151, 28);
            cboLocalidad.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 240);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 24;
            label5.Text = "Localidad:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(439, 180);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(260, 27);
            txtTelefono.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 187);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 22;
            label6.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(439, 132);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(260, 27);
            txtDireccion.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 135);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 18;
            label3.Text = "Dirección:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 35;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(462, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(183, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 35;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(260, 400);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(183, 37);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(439, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 27);
            txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 91);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // cboCondicionIva
            // 
            cboCondicionIva.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondicionIva.FormattingEnabled = true;
            cboCondicionIva.Location = new Point(439, 341);
            cboCondicionIva.Name = "cboCondicionIva";
            cboCondicionIva.Size = new Size(151, 28);
            cboCondicionIva.TabIndex = 28;
            // 
            // ProveedoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControlLista);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProveedoresView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Proveedores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlLista.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProveedores).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlLista;
        private TabPage tabPageLista;
        private TabPage tabPageAgregarEditar;
        private TextBox txtFiltro;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgreg;
        private DataGridView dataGridProveedores;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtDireccion;
        private Label label3;
        private Label label5;
        private ComboBox cboLocalidad;
        private Label label7;
        private TextBox txtCbu;
        private Label label8;
        private ComboBox cboCondicionIva;
    }
}