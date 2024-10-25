namespace Localizame.vista
{
    partial class frmInformes2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformes2));
            btnExcel = new Button();
            gridGeocercas = new DataGridView();
            label1 = new Label();
            btnAtras = new Button();
            btnCerrar = new Button();
            btnConsultar = new Button();
            dtpFechaFinal = new DateTimePicker();
            dtpFechaInicial = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbVehiculo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridGeocercas).BeginInit();
            SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Black;
            btnExcel.FlatStyle = FlatStyle.Popup;
            btnExcel.ForeColor = SystemColors.ControlLightLight;
            btnExcel.Location = new Point(15, 344);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(848, 23);
            btnExcel.TabIndex = 39;
            btnExcel.Text = "Exportar a excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // gridGeocercas
            // 
            gridGeocercas.AllowUserToAddRows = false;
            gridGeocercas.AllowUserToDeleteRows = false;
            gridGeocercas.AllowUserToOrderColumns = true;
            gridGeocercas.AllowUserToResizeColumns = false;
            gridGeocercas.AllowUserToResizeRows = false;
            gridGeocercas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridGeocercas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridGeocercas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGeocercas.Location = new Point(15, 119);
            gridGeocercas.Name = "gridGeocercas";
            gridGeocercas.ReadOnly = true;
            gridGeocercas.Size = new Size(848, 207);
            gridGeocercas.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(339, 12);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 37;
            label1.Text = "Informe de geocercas";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(14, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(93, 23);
            btnAtras.TabIndex = 36;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ButtonFace;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(846, 9);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
            btnCerrar.TabIndex = 35;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Black;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(773, 75);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 23);
            btnConsultar.TabIndex = 34;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(503, 76);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(248, 23);
            dtpFechaFinal.TabIndex = 33;
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Format = DateTimePickerFormat.Short;
            dtpFechaInicial.Location = new Point(257, 76);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(219, 23);
            dtpFechaInicial.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(503, 55);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 31;
            label4.Text = "Fecha final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(257, 55);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 30;
            label3.Text = "Fecha inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 55);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 29;
            label2.Text = "Vehiculo";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Items.AddRange(new object[] { "Selecciona una opcion" });
            cmbVehiculo.Location = new Point(15, 76);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(217, 23);
            cmbVehiculo.TabIndex = 28;
            // 
            // frmInformes2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(875, 381);
            Controls.Add(btnExcel);
            Controls.Add(gridGeocercas);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Controls.Add(btnCerrar);
            Controls.Add(btnConsultar);
            Controls.Add(dtpFechaFinal);
            Controls.Add(dtpFechaInicial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbVehiculo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInformes2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informes";
            ((System.ComponentModel.ISupportInitialize)gridGeocercas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcel;
        private DataGridView gridGeocercas;
        private Label label1;
        private Button btnAtras;
        private Button btnCerrar;
        private Button btnConsultar;
        private DateTimePicker dtpFechaFinal;
        private DateTimePicker dtpFechaInicial;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbVehiculo;
    }
}