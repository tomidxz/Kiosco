namespace KioscoInformaticoDesktop.Views
{
    partial class ComprasView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnFinish = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            numericTotalCom = new NumericUpDown();
            btnDelete = new FontAwesome.Sharp.IconButton();
            dataGridDetallesCompra = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            numericSubtotalCom = new NumericUpDown();
            label6 = new Label();
            numericCantidadCom = new NumericUpDown();
            label5 = new Label();
            numericPrecioCom = new NumericUpDown();
            comboProductos = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            comboProveedor = new ComboBox();
            comboFormasDePago = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dateTimeFecha = new DateTimePicker();
            btnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)numericTotalCom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetallesCompra).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotalCom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidadCom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioCom).BeginInit();
            SuspendLayout();
            // 
            // btnFinish
            // 
            btnFinish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinish.BackColor = Color.DarkGreen;
            btnFinish.ForeColor = Color.White;
            btnFinish.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnFinish.IconColor = Color.White;
            btnFinish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinish.IconSize = 30;
            btnFinish.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinish.Location = new Point(660, 451);
            btnFinish.Margin = new Padding(3, 4, 3, 4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(123, 73);
            btnFinish.TabIndex = 28;
            btnFinish.Text = "Finalizar Compra";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(523, 465);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 27;
            label8.Text = "Total Factura:";
            // 
            // numericTotalCom
            // 
            numericTotalCom.Enabled = false;
            numericTotalCom.Location = new Point(510, 488);
            numericTotalCom.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericTotalCom.Name = "numericTotalCom";
            numericTotalCom.Size = new Size(109, 27);
            numericTotalCom.TabIndex = 26;
            numericTotalCom.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 44;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(660, 346);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 73);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "&Quitar";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridDetallesCompra
            // 
            dataGridDetallesCompra.AllowUserToAddRows = false;
            dataGridDetallesCompra.AllowUserToDeleteRows = false;
            dataGridDetallesCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDetallesCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridDetallesCompra.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridDetallesCompra.Location = new Point(42, 265);
            dataGridDetallesCompra.Name = "dataGridDetallesCompra";
            dataGridDetallesCompra.ReadOnly = true;
            dataGridDetallesCompra.RowHeadersWidth = 51;
            dataGridDetallesCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDetallesCompra.Size = new Size(599, 154);
            dataGridDetallesCompra.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numericSubtotalCom);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numericCantidadCom);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericPrecioCom);
            panel1.Controls.Add(comboProductos);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(28, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 125);
            panel1.TabIndex = 23;
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
            // numericSubtotalCom
            // 
            numericSubtotalCom.Enabled = false;
            numericSubtotalCom.Location = new Point(435, 63);
            numericSubtotalCom.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericSubtotalCom.Name = "numericSubtotalCom";
            numericSubtotalCom.Size = new Size(109, 27);
            numericSubtotalCom.TabIndex = 12;
            numericSubtotalCom.TextAlign = HorizontalAlignment.Right;
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
            // numericCantidadCom
            // 
            numericCantidadCom.Location = new Point(339, 64);
            numericCantidadCom.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericCantidadCom.Name = "numericCantidadCom";
            numericCantidadCom.Size = new Size(79, 27);
            numericCantidadCom.TabIndex = 10;
            numericCantidadCom.TextAlign = HorizontalAlignment.Right;
            numericCantidadCom.ValueChanged += numericCantidadCom_ValueChanged_1;
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
            // numericPrecioCom
            // 
            numericPrecioCom.Enabled = false;
            numericPrecioCom.Location = new Point(172, 64);
            numericPrecioCom.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericPrecioCom.Name = "numericPrecioCom";
            numericPrecioCom.Size = new Size(150, 27);
            numericPrecioCom.TabIndex = 8;
            numericPrecioCom.TextAlign = HorizontalAlignment.Right;
            numericPrecioCom.ValueChanged += numericPrecioCom_ValueChanged;
            // 
            // comboProductos
            // 
            comboProductos.FormattingEnabled = true;
            comboProductos.Location = new Point(3, 63);
            comboProductos.Name = "comboProductos";
            comboProductos.Size = new Size(151, 28);
            comboProductos.TabIndex = 6;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 72);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 22;
            label3.Text = "Proveedor:";
            // 
            // comboProveedor
            // 
            comboProveedor.FormattingEnabled = true;
            comboProveedor.Location = new Point(465, 72);
            comboProveedor.Name = "comboProveedor";
            comboProveedor.Size = new Size(228, 28);
            comboProveedor.TabIndex = 21;
            // 
            // comboFormasDePago
            // 
            comboFormasDePago.FormattingEnabled = true;
            comboFormasDePago.Location = new Point(148, 69);
            comboFormasDePago.Name = "comboFormasDePago";
            comboFormasDePago.Size = new Size(151, 28);
            comboFormasDePago.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 72);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 19;
            label2.Text = "Forma de pago:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(617, 22);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 18;
            label1.Text = "Fecha";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Enabled = false;
            dateTimeFecha.Format = DateTimePickerFormat.Short;
            dateTimeFecha.Location = new Point(683, 17);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(121, 27);
            dateTimeFecha.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.OrangeRed;
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(660, 256);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 62);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "&Agregar";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ComprasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 540);
            Controls.Add(btnAdd);
            Controls.Add(btnFinish);
            Controls.Add(label8);
            Controls.Add(numericTotalCom);
            Controls.Add(btnDelete);
            Controls.Add(dataGridDetallesCompra);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(comboProveedor);
            Controls.Add(comboFormasDePago);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimeFecha);
            Name = "ComprasView";
            Text = "ComprasView";
            ((System.ComponentModel.ISupportInitialize)numericTotalCom).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetallesCompra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotalCom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidadCom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioCom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFinish;
        private Label label8;
        private NumericUpDown numericTotalCom;
        private FontAwesome.Sharp.IconButton btnDelete;
        private DataGridView dataGridDetallesCompra;
        private Panel panel1;
        private Label label7;
        private NumericUpDown numericSubtotalCom;
        private Label label6;
        private NumericUpDown numericCantidadCom;
        private Label label5;
        private NumericUpDown numericPrecioCom;
        private ComboBox comboProductos;
        private Label label4;
        private Label label3;
        private ComboBox comboProveedor;
        private ComboBox comboFormasDePago;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimeFecha;
        private FontAwesome.Sharp.IconButton btnAdd;
    }
}