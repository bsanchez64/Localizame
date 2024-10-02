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
            btnGeocerca = new Button();
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
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 9;
            label1.Text = "Creación de geocercas";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(948, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
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
            gMapControl1.Location = new Point(12, 48);
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
            gMapControl1.Size = new Size(645, 439);
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
            btnAgregar.Location = new Point(674, 208);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 23);
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
            btnEliminar.Location = new Point(770, 208);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 23);
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
            btnAtras.Location = new Point(3, 11);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(90, 23);
            btnAtras.TabIndex = 14;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(695, 66);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(274, 23);
            txtDescripcion.TabIndex = 15;
            // 
            // txtLatitud
            // 
            txtLatitud.Location = new Point(695, 115);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(274, 23);
            txtLatitud.TabIndex = 16;
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(695, 169);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(274, 23);
            txtLongitud.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(695, 48);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 18;
            label2.Text = "Descripción";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(695, 97);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 19;
            label3.Text = "Latitud";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(695, 151);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 20;
            label4.Text = "Longitud";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(673, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(296, 210);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellMouseClick += SeleccionarRegistro;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAtras);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 44);
            panel1.TabIndex = 22;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // btnGeocerca
            // 
            btnGeocerca.BackColor = Color.Black;
            btnGeocerca.FlatStyle = FlatStyle.Popup;
            btnGeocerca.ForeColor = Color.White;
            btnGeocerca.Location = new Point(866, 208);
            btnGeocerca.Name = "btnGeocerca";
            btnGeocerca.Size = new Size(90, 23);
            btnGeocerca.TabIndex = 23;
            btnGeocerca.Text = "Geocerca";
            btnGeocerca.UseVisualStyleBackColor = false;
            btnGeocerca.Click += btnGeocerca_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(673, 247);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 23);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmGeocercas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 499);
            Controls.Add(btnGuardar);
            Controls.Add(btnGeocerca);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnGeocerca;
        private Button btnGuardar;
    }
}