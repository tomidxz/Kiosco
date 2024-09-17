namespace KioscoInformaticoDesktop.Views
{
    partial class LocalidadesView
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            tabControl = new TabControl();
            tabLista = new TabPage();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            DataGridLocalidades = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            tabControl.SuspendLayout();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridLocalidades).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Localidades";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabLista);
            tabControl.Controls.Add(tabPageAgregarEditar);
            tabControl.Location = new Point(1, 123);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(746, 425);
            tabControl.TabIndex = 1;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(label3);
            tabLista.Controls.Add(txtFiltro);
            tabLista.Controls.Add(btnEliminar);
            tabLista.Controls.Add(btnEditar);
            tabLista.Controls.Add(btnAgregar);
            tabLista.Controls.Add(DataGridLocalidades);
            tabLista.Location = new Point(4, 29);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(738, 392);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(592, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 40);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 14);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(59, 11);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(527, 27);
            txtFiltro.TabIndex = 4;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(592, 247);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 30;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(592, 188);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(121, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 30;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(592, 128);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 40);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // DataGridLocalidades
            // 
            DataGridLocalidades.AllowUserToAddRows = false;
            DataGridLocalidades.AllowUserToDeleteRows = false;
            DataGridLocalidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridLocalidades.Location = new Point(0, 51);
            DataGridLocalidades.Name = "DataGridLocalidades";
            DataGridLocalidades.ReadOnly = true;
            DataGridLocalidades.RowHeadersWidth = 51;
            DataGridLocalidades.Size = new Size(586, 330);
            DataGridLocalidades.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(BtnCancelar);
            tabPageAgregarEditar.Controls.Add(BtnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 29);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(738, 392);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 30;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(457, 261);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(129, 29);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 30;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(122, 261);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(122, 29);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(251, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(334, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 59);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre: ";
            // 
            // LocalidadesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 545);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "LocalidadesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Localidades";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridLocalidades).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabLista;
        private TabPage tabPageAgregarEditar;
        private DataGridView DataGridLocalidades;
        private TextBox txtNombre;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource bindingSource1;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private TextBox txtFiltro;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label3;
    }
}