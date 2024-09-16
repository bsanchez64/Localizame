﻿namespace Localizame.vista
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
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(964, 11);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
            btnCerrar.TabIndex = 5;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(93, 23);
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
            gMapControl1.Location = new Point(12, 110);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
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
            gMapControl1.Size = new Size(973, 416);
            gMapControl1.TabIndex = 7;
            gMapControl1.Zoom = 0D;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(420, 6);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 8;
            label1.Text = "Gestión de rutas ";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(12, 67);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(217, 23);
            cmbVehiculo.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 10;
            label2.Text = "Vehiculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(254, 46);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 11;
            label3.Text = "Fecha Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(500, 46);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 12;
            label4.Text = "Fecha Final";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Location = new Point(254, 67);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(231, 23);
            dtpFechaInicial.TabIndex = 13;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(500, 67);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(253, 23);
            dtpFechaFinal.TabIndex = 14;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Black;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(770, 66);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 23);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnUbicacionUltima
            // 
            btnUbicacionUltima.BackColor = Color.Black;
            btnUbicacionUltima.FlatStyle = FlatStyle.Popup;
            btnUbicacionUltima.ForeColor = Color.White;
            btnUbicacionUltima.Location = new Point(866, 66);
            btnUbicacionUltima.Name = "btnUbicacionUltima";
            btnUbicacionUltima.Size = new Size(119, 23);
            btnUbicacionUltima.TabIndex = 16;
            btnUbicacionUltima.Text = "Última Ubicación";
            btnUbicacionUltima.UseVisualStyleBackColor = false;
            // 
            // frmGestionRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(997, 538);
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
            Name = "frmGestionRutas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGestionRutas";
            Load += frmGestionRutas_Load;
            MouseMove += frmGestionRutas_MouseMove;
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
    }
}