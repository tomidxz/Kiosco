namespace KioscoInformaticoDesktop.Views
{
    partial class HistoricoVentasView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridVentas = new DataGridView();
            panelFiltrado = new Panel();
            btnFiltrar = new Button();
            dateTimeHasta = new DateTimePicker();
            label3 = new Label();
            dateTimeDesde = new DateTimePicker();
            label2 = new Label();
            checkFiltro = new CheckBox();
            numericTotal = new NumericUpDown();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            panelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 84);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 0;
            label1.Text = "Historico Ventas";
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridVentas.Location = new Point(12, 164);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridVentas.RowHeadersWidth = 51;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(776, 198);
            dataGridVentas.TabIndex = 3;
            // 
            // panelFiltrado
            // 
            panelFiltrado.BorderStyle = BorderStyle.Fixed3D;
            panelFiltrado.Controls.Add(btnFiltrar);
            panelFiltrado.Controls.Add(dateTimeHasta);
            panelFiltrado.Controls.Add(label3);
            panelFiltrado.Controls.Add(dateTimeDesde);
            panelFiltrado.Controls.Add(label2);
            panelFiltrado.Enabled = false;
            panelFiltrado.Location = new Point(131, 93);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(646, 53);
            panelFiltrado.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(496, 11);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(346, 14);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(103, 27);
            dateTimeHasta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 15);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Hasta:";
            // 
            // dateTimeDesde
            // 
            dateTimeDesde.Format = DateTimePickerFormat.Short;
            dateTimeDesde.Location = new Point(100, 14);
            dateTimeDesde.Name = "dateTimeDesde";
            dateTimeDesde.Size = new Size(103, 27);
            dateTimeDesde.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 14);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "Desde:";
            // 
            // checkFiltro
            // 
            checkFiltro.AutoSize = true;
            checkFiltro.Location = new Point(12, 109);
            checkFiltro.Name = "checkFiltro";
            checkFiltro.Size = new Size(113, 24);
            checkFiltro.TabIndex = 0;
            checkFiltro.Text = "Activar filtro";
            checkFiltro.UseVisualStyleBackColor = true;
            checkFiltro.CheckedChanged += checkFiltro_CheckedChanged;
            // 
            // numericTotal
            // 
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(629, 400);
            numericTotal.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(109, 27);
            numericTotal.TabIndex = 15;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 402);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 16;
            label4.Text = "Total facturado:";
            // 
            // HistoricoVentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(numericTotal);
            Controls.Add(checkFiltro);
            Controls.Add(panelFiltrado);
            Controls.Add(dataGridVentas);
            Controls.Add(panel1);
            Name = "HistoricoVentasView";
            Text = "HistoricoVentasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            panelFiltrado.ResumeLayout(false);
            panelFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridVentas;
        private Panel panelFiltrado;
        private DateTimePicker dateTimeHasta;
        private Label label3;
        private DateTimePicker dateTimeDesde;
        private Label label2;
        private CheckBox checkFiltro;
        private Button btnFiltrar;
        private NumericUpDown numericTotal;
        private Label label4;
    }
}