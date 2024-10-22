namespace Localizame.vista
{
    partial class frmGestionRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionRutas));
            btnCerrar = new Button();
            btnAtras = new Button();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            label1 = new Label();
            cmbVehiculo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFechaInicial = new DateTimePicker();
            dtpFechaFinal = new DateTimePicker();
            btnConsultar = new Button();
            btnUbicacionUltima = new Button();
            btnSatelite = new Button();
            btnOriginal = new Button();
            btnRelieve = new Button();
            label5 = new Label();
            label6 = new Label();
            trackZoom = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            chkGeocercas = new CheckBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackZoom).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(1102, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 27);
            btnCerrar.TabIndex = 5;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(14, 16);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(106, 31);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(14, 147);
            gMapControl1.Margin = new Padding(3, 4, 3, 4);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 17;
            gMapControl1.MinZoom = 0;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(1112, 555);
            gMapControl1.TabIndex = 7;
            gMapControl1.Zoom = 0D;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(480, 8);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 8;
            label1.Text = "Gestión de rutas ";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Items.AddRange(new object[] { "Selecciona una opcion" });
            cmbVehiculo.Location = new Point(14, 89);
            cmbVehiculo.Margin = new Padding(3, 4, 3, 4);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(247, 28);
            cmbVehiculo.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 61);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 10;
            label2.Text = "Vehiculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(290, 61);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 11;
            label3.Text = "Fecha inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(571, 61);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 12;
            label4.Text = "Fecha final";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Format = DateTimePickerFormat.Short;
            dtpFechaInicial.Location = new Point(290, 89);
            dtpFechaInicial.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(250, 27);
            dtpFechaInicial.TabIndex = 13;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(571, 89);
            dtpFechaFinal.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(283, 27);
            dtpFechaFinal.TabIndex = 14;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Black;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(880, 88);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(103, 31);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnUbicacionUltima
            // 
            btnUbicacionUltima.BackColor = Color.Black;
            btnUbicacionUltima.FlatStyle = FlatStyle.Popup;
            btnUbicacionUltima.ForeColor = Color.White;
            btnUbicacionUltima.Location = new Point(990, 88);
            btnUbicacionUltima.Margin = new Padding(3, 4, 3, 4);
            btnUbicacionUltima.Name = "btnUbicacionUltima";
            btnUbicacionUltima.Size = new Size(136, 31);
            btnUbicacionUltima.TabIndex = 16;
            btnUbicacionUltima.Text = "Última Ubicación";
            btnUbicacionUltima.UseVisualStyleBackColor = false;
            btnUbicacionUltima.Click += btnUbicacionUltima_Click;
            // 
            // btnSatelite
            // 
            btnSatelite.Location = new Point(16, 747);
            btnSatelite.Name = "btnSatelite";
            btnSatelite.Size = new Size(94, 29);
            btnSatelite.TabIndex = 17;
            btnSatelite.Text = "Satelite";
            btnSatelite.UseVisualStyleBackColor = true;
            btnSatelite.Click += btnSatelite_Click;
            // 
            // btnOriginal
            // 
            btnOriginal.Location = new Point(117, 747);
            btnOriginal.Name = "btnOriginal";
            btnOriginal.Size = new Size(94, 29);
            btnOriginal.TabIndex = 18;
            btnOriginal.Text = "Normal";
            btnOriginal.UseVisualStyleBackColor = true;
            btnOriginal.Click += btnOriginal_Click;
            // 
            // btnRelieve
            // 
            btnRelieve.Location = new Point(216, 747);
            btnRelieve.Name = "btnRelieve";
            btnRelieve.Size = new Size(94, 29);
            btnRelieve.TabIndex = 19;
            btnRelieve.Text = "Relieve";
            btnRelieve.UseVisualStyleBackColor = true;
            btnRelieve.Click += btnRelieve_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(15, 712);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 21;
            label5.Text = "Tipo de mapa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(733, 717);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 22;
            label6.Text = "Zoom de mapa";
            // 
            // trackZoom
            // 
            trackZoom.BackColor = SystemColors.ActiveCaptionText;
            trackZoom.Location = new Point(722, 741);
            trackZoom.Maximum = 23;
            trackZoom.Name = "trackZoom";
            trackZoom.Size = new Size(405, 56);
            trackZoom.TabIndex = 23;
            trackZoom.Value = 8;
            trackZoom.ValueChanged += trackZoom_ValueChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // chkGeocercas
            // 
            chkGeocercas.AutoSize = true;
            chkGeocercas.BackColor = Color.Transparent;
            chkGeocercas.ForeColor = SystemColors.ControlLight;
            chkGeocercas.Location = new Point(363, 745);
            chkGeocercas.Margin = new Padding(3, 4, 3, 4);
            chkGeocercas.Name = "chkGeocercas";
            chkGeocercas.Size = new Size(124, 24);
            chkGeocercas.TabIndex = 25;
            chkGeocercas.Text = "Ver Geocercas";
            chkGeocercas.UseVisualStyleBackColor = false;
            chkGeocercas.CheckedChanged += chkGeocercas_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(360, 717);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 24;
            label7.Text = "Opciones";
            // 
            // frmGestionRutas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1139, 785);
            Controls.Add(chkGeocercas);
            Controls.Add(label7);
            Controls.Add(trackZoom);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnRelieve);
            Controls.Add(btnOriginal);
            Controls.Add(btnSatelite);
            Controls.Add(btnUbicacionUltima);
            Controls.Add(btnConsultar);
            Controls.Add(dtpFechaFinal);
            Controls.Add(dtpFechaInicial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbVehiculo);
            Controls.Add(label1);
            Controls.Add(gMapControl1);
            Controls.Add(btnAtras);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGestionRutas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGestionRutas";
            Load += frmGestionRutas_Load;
            MouseMove += frmGestionRutas_MouseMove;
            ((System.ComponentModel.ISupportInitialize)trackZoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnAtras;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Label label1;
        private ComboBox cmbVehiculo;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaInicial;
        private DateTimePicker dtpFechaFinal;
        private Button btnConsultar;
        private Button btnUbicacionUltima;
        private Button btnSatelite;
        private Button btnOriginal;
        private Button btnRelieve;
        private Label label5;
        private Label label6;
        private TrackBar trackZoom;
        private System.Windows.Forms.Timer timer1;
        private CheckBox chkGeocercas;
        private Label label7;
    }
}