namespace Localizame.vista
{
    partial class frmInformes1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformes1));
            btnConsultar = new Button();
            dtpFechaFinal = new DateTimePicker();
            dtpFechaInicial = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbVehiculo = new ComboBox();
            label1 = new Label();
            btnAtras = new Button();
            btnCerrar = new Button();
            gridOperadores = new DataGridView();
            btnExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)gridOperadores).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Black;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(771, 74);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 23);
            btnConsultar.TabIndex = 22;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(501, 75);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(248, 23);
            dtpFechaFinal.TabIndex = 21;
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Format = DateTimePickerFormat.Short;
            dtpFechaInicial.Location = new Point(255, 75);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(219, 23);
            dtpFechaInicial.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(501, 54);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 19;
            label4.Text = "Fecha final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(255, 54);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 18;
            label3.Text = "Fecha inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 54);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 17;
            label2.Text = "Vehiculo";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Items.AddRange(new object[] { "Selecciona una opcion", "EQW508", "STC463" });
            cmbVehiculo.Location = new Point(13, 75);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(217, 23);
            cmbVehiculo.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(344, 8);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 25;
            label1.Text = "Informe de conductores";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(12, 11);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(93, 23);
            btnAtras.TabIndex = 24;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(844, 8);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
            btnCerrar.TabIndex = 23;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // gridOperadores
            // 
            gridOperadores.AllowUserToAddRows = false;
            gridOperadores.AllowUserToDeleteRows = false;
            gridOperadores.AllowUserToOrderColumns = true;
            gridOperadores.AllowUserToResizeColumns = false;
            gridOperadores.AllowUserToResizeRows = false;
            gridOperadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridOperadores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridOperadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOperadores.Location = new Point(13, 118);
            gridOperadores.Name = "gridOperadores";
            gridOperadores.ReadOnly = true;
            gridOperadores.Size = new Size(848, 207);
            gridOperadores.TabIndex = 26;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Black;
            btnExcel.FlatStyle = FlatStyle.Popup;
            btnExcel.ForeColor = SystemColors.ControlLightLight;
            btnExcel.Location = new Point(13, 343);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(848, 23);
            btnExcel.TabIndex = 27;
            btnExcel.Text = "Exportar a excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // frmInformes1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(877, 381);
            Controls.Add(btnExcel);
            Controls.Add(gridOperadores);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInformes1";
            Text = "Informes";
            ((System.ComponentModel.ISupportInitialize)gridOperadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private DateTimePicker dtpFechaFinal;
        private DateTimePicker dtpFechaInicial;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbVehiculo;
        private Label label1;
        private Button btnAtras;
        private Button btnCerrar;
        private DataGridView gridOperadores;
        private Button btnExcel;
    }
}