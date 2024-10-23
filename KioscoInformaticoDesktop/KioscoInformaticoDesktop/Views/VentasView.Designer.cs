namespace KioscoInformaticoDesktop.Views
{
    partial class VentasView
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
            dateTimeFecha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            comboFormasDePago = new ComboBox();
            comboClientes = new ComboBox();
            label3 = new Label();
            comboProductos = new ComboBox();
            label4 = new Label();
            panel1 = new Panel();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            numericSubtotal = new NumericUpDown();
            label6 = new Label();
            numericCantidad = new NumericUpDown();
            label5 = new Label();
            numericPrecio = new NumericUpDown();
            dataGridDetallesVenta = new DataGridView();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            numericTotal = new NumericUpDown();
            btnFinalizarVenta = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetallesVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Enabled = false;
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(667, 19);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(121, 27);
            dateTimeFecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Forma de pago:";
            // 
            // comboFormasDePago
            // 
            comboFormasDePago.FormattingEnabled = true;
            comboFormasDePago.Location = new Point(132, 71);
            comboFormasDePago.Name = "comboFormasDePago";
            comboFormasDePago.Size = new Size(151, 28);
            comboFormasDePago.TabIndex = 3;
            // 
            // comboClientes
            // 
            comboClientes.FormattingEnabled = true;
            comboClientes.Location = new Point(397, 71);
            comboClientes.Name = "comboClientes";
            comboClientes.Size = new Size(228, 28);
            comboClientes.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 74);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Cliente:";
            // 
            // comboProductos
            // 
            comboProductos.FormattingEnabled = true;
            comboProductos.Location = new Point(3, 63);
            comboProductos.Name = "comboProductos";
            comboProductos.Size = new Size(151, 28);
            comboProductos.TabIndex = 6;
            comboProductos.SelectedIndexChanged += comboProductos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 29);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Producto:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numericSubtotal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericCantidad);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericPrecio);
            panel1.Controls.Add(comboProductos);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 125);
            panel1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.OrangeRed;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(621, 29);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 62);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 29);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 13;
            label7.Text = "Subtotal";
            // 
            // numericSubtotal
            // 
            numericSubtotal.Enabled = false;
            numericSubtotal.Location = new Point(435, 63);
            numericSubtotal.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericSubtotal.Name = "numericSubtotal";
            numericSubtotal.Size = new Size(109, 27);
            numericSubtotal.TabIndex = 12;
            numericSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 29);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Cantidad:";
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(339, 64);
            numericCantidad.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(79, 27);
            numericCantidad.TabIndex = 10;
            numericCantidad.TextAlign = HorizontalAlignment.Right;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 29);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 9;
            label5.Text = "Precio:";
            // 
            // numericPrecio
            // 
            numericPrecio.Enabled = false;
            numericPrecio.Location = new Point(172, 64);
            numericPrecio.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(150, 27);
            numericPrecio.TabIndex = 8;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            numericPrecio.ValueChanged += numericPrecio_ValueChanged;
            // 
            // dataGridDetallesVenta
            // 
            dataGridDetallesVenta.AllowUserToAddRows = false;
            dataGridDetallesVenta.AllowUserToDeleteRows = false;
            dataGridDetallesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridDetallesVenta.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridDetallesVenta.Location = new Point(26, 267);
            dataGridDetallesVenta.Name = "dataGridDetallesVenta";
            dataGridDetallesVenta.ReadOnly = true;
            dataGridDetallesVenta.RowHeadersWidth = 51;
            dataGridDetallesVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDetallesVenta.Size = new Size(599, 154);
            dataGridDetallesVenta.TabIndex = 9;
            dataGridDetallesVenta.DataBindingComplete += dataGridDetallesVenta_DataBindingComplete;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitar.BackColor = Color.OrangeRed;
            btnQuitar.ForeColor = Color.White;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnQuitar.IconColor = Color.White;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.IconSize = 44;
            btnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitar.Location = new Point(644, 319);
            btnQuitar.Margin = new Padding(3, 4, 3, 4);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(123, 73);
            btnQuitar.TabIndex = 11;
            btnQuitar.Text = "&Quitar";
            btnQuitar.TextAlign = ContentAlignment.MiddleRight;
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(429, 476);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 15;
            label8.Text = "Total Factura:";
            // 
            // numericTotal
            // 
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(416, 499);
            numericTotal.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(109, 27);
            numericTotal.TabIndex = 14;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinalizarVenta.BackColor = Color.OrangeRed;
            btnFinalizarVenta.ForeColor = Color.White;
            btnFinalizarVenta.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnFinalizarVenta.IconColor = Color.White;
            btnFinalizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarVenta.IconSize = 44;
            btnFinalizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarVenta.Location = new Point(644, 453);
            btnFinalizarVenta.Margin = new Padding(3, 4, 3, 4);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(123, 73);
            btnFinalizarVenta.TabIndex = 16;
            btnFinalizarVenta.Text = "&Finalizar Venta";
            btnFinalizarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 578);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(label8);
            Controls.Add(numericTotal);
            Controls.Add(btnQuitar);
            Controls.Add(dataGridDetallesVenta);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(comboClientes);
            Controls.Add(comboFormasDePago);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimeFecha);
            Name = "VentasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetallesVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFecha;
        private Label label1;
        private Label label2;
        private ComboBox comboFormasDePago;
        private ComboBox comboClientes;
        private Label label3;
        private ComboBox comboProductos;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private NumericUpDown numericPrecio;
        private Label label7;
        private NumericUpDown numericSubtotal;
        private Label label6;
        private NumericUpDown numericCantidad;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dataGridDetallesVenta;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private Label label8;
        private NumericUpDown numericTotal;
        private FontAwesome.Sharp.IconButton btnFinalizarVenta;
    }
}