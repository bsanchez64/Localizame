namespace Localizame.vista
{
    partial class frmGeocercas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeocercas));
            label1 = new Label();
            btnCerrar = new Button();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnAtras = new Button();
            txtDescripcion = new TextBox();
            txtLatitud = new TextBox();
            txtLongitud = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(464, 12);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 9;
            label1.Text = "Creación de geocercas";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(1083, 12);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 27);
            btnCerrar.TabIndex = 10;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(14, 64);
            gMapControl1.Margin = new Padding(3, 4, 3, 4);
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
            gMapControl1.Size = new Size(737, 585);
            gMapControl1.TabIndex = 11;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            gMapControl1.DoubleClick += gMapControl1_DoubleClick;
            gMapControl1.MouseDoubleClick += gMapControl1_MouseDoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(769, 267);
            btnAgregar.Margin = new Padding(3, 5, 3, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 31);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(941, 267);
            btnEliminar.Margin = new Padding(3, 5, 3, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 31);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Black;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(13, 15);
            btnAtras.Margin = new Padding(3, 5, 3, 5);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(127, 31);
            btnAtras.TabIndex = 14;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(770, 88);
            txtDescripcion.Margin = new Padding(3, 5, 3, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(323, 27);
            txtDescripcion.TabIndex = 15;
            // 
            // txtLatitud
            // 
            txtLatitud.Enabled = false;
            txtLatitud.Location = new Point(770, 153);
            txtLatitud.Margin = new Padding(3, 5, 3, 5);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(323, 27);
            txtLatitud.TabIndex = 16;
            // 
            // txtLongitud
            // 
            txtLongitud.Enabled = false;
            txtLongitud.Location = new Point(770, 220);
            txtLongitud.Margin = new Padding(3, 5, 3, 5);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(323, 27);
            txtLongitud.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(770, 64);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 18;
            label2.Text = "Descripción";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(770, 129);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 19;
            label3.Text = "Latitud";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(770, 192);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 20;
            label4.Text = "Longitud";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(769, 323);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(324, 280);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellMouseClick += SeleccionarRegistro;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAtras);
            panel1.Location = new Point(1, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 59);
            panel1.TabIndex = 22;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(769, 614);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(324, 31);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmGeocercas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1121, 665);
            Controls.Add(btnGuardar);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLongitud);
            Controls.Add(txtLatitud);
            Controls.Add(txtDescripcion);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(gMapControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGeocercas";
            Text = "frmGeocercas";
            Load += frmGeocercas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCerrar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnAtras;
        private TextBox txtDescripcion;
        private TextBox txtLatitud;
        private TextBox txtLongitud;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnGuardar;
    }
}