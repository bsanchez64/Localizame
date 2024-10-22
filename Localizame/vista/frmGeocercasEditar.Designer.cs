namespace Localizame.vista
{
    partial class frmGeocercasEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeocercasEditar));
            cbxGeocercas = new ComboBox();
            label1 = new Label();
            btnGuardar = new Button();
            panel1 = new Panel();
            btnCerrar = new Button();
            label2 = new Label();
            btnAtras = new Button();
            gridGeocercas = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            txtDescripcion = new TextBox();
            btnEliminar = new Button();
            btnAgregar = new Button();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridGeocercas).BeginInit();
            SuspendLayout();
            // 
            // cbxGeocercas
            // 
            cbxGeocercas.FormattingEnabled = true;
            cbxGeocercas.Location = new Point(682, 69);
            cbxGeocercas.Margin = new Padding(3, 2, 3, 2);
            cbxGeocercas.Name = "cbxGeocercas";
            cbxGeocercas.Size = new Size(283, 23);
            cbxGeocercas.TabIndex = 0;
            cbxGeocercas.SelectedValueChanged += cbxGeocercas_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(402, 7);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 9;
            label1.Text = "Creación de geocercas";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(683, 410);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(284, 23);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAtras);
            panel1.Location = new Point(10, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 44);
            panel1.TabIndex = 35;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(946, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
            btnCerrar.TabIndex = 10;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(406, 9);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 9;
            label2.Text = "Editar geocercas";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Black;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(3, 11);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(114, 23);
            btnAtras.TabIndex = 14;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // gridGeocercas
            // 
            gridGeocercas.AllowUserToAddRows = false;
            gridGeocercas.AllowUserToResizeColumns = false;
            gridGeocercas.AllowUserToResizeRows = false;
            gridGeocercas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridGeocercas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridGeocercas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGeocercas.Location = new Point(682, 187);
            gridGeocercas.Name = "gridGeocercas";
            gridGeocercas.ReadOnly = true;
            gridGeocercas.RowHeadersVisible = false;
            gridGeocercas.RowHeadersWidth = 51;
            gridGeocercas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridGeocercas.Size = new Size(284, 210);
            gridGeocercas.TabIndex = 34;
            gridGeocercas.CellClick += gridGeocercas_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(682, 95);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 33;
            label4.Text = "Nombre geocerca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(683, 52);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 31;
            label5.Text = "Selecciona la geocerca";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(682, 114);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(283, 23);
            txtDescripcion.TabIndex = 28;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(832, 148);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 23);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(682, 148);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 23);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(10, 52);
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
            gMapControl1.Size = new Size(656, 439);
            gMapControl1.TabIndex = 25;
            gMapControl1.Zoom = 0D;
            gMapControl1.MouseDoubleClick += gMapControl1_MouseDoubleClick;
            // 
            // frmGeocercasEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(988, 508);
            Controls.Add(btnGuardar);
            Controls.Add(panel1);
            Controls.Add(gridGeocercas);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(gMapControl1);
            Controls.Add(label1);
            Controls.Add(cbxGeocercas);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGeocercasEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar geocercas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridGeocercas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxGeocercas;
        private Label label1;
        private Button btnGuardar;
        private Panel panel1;
        private Button btnCerrar;
        private Label label2;
        private Button btnAtras;
        private DataGridView gridGeocercas;
        private Label label4;
        private Label label5;
        private TextBox txtDescripcion;
        private Button btnEliminar;
        private Button btnAgregar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}