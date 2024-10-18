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
            cbxGeocercas.Location = new Point(781, 92);
            cbxGeocercas.Name = "cbxGeocercas";
            cbxGeocercas.Size = new Size(322, 28);
            cbxGeocercas.TabIndex = 0;
            cbxGeocercas.SelectedValueChanged += cbxGeocercas_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(459, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 9;
            label1.Text = "Creación de geocercas";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(781, 547);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(325, 31);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAtras);
            panel1.Location = new Point(11, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 59);
            panel1.TabIndex = 35;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(1081, 11);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 27);
            btnCerrar.TabIndex = 10;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(464, 12);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 9;
            label2.Text = "Editar geocercas";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Black;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(3, 15);
            btnAtras.Margin = new Padding(3, 5, 3, 5);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(130, 31);
            btnAtras.TabIndex = 14;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            // 
            // gridGeocercas
            // 
            gridGeocercas.AllowUserToAddRows = false;
            gridGeocercas.AllowUserToResizeColumns = false;
            gridGeocercas.AllowUserToResizeRows = false;
            gridGeocercas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridGeocercas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridGeocercas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGeocercas.Location = new Point(779, 249);
            gridGeocercas.Margin = new Padding(3, 4, 3, 4);
            gridGeocercas.Name = "gridGeocercas";
            gridGeocercas.ReadOnly = true;
            gridGeocercas.RowHeadersVisible = false;
            gridGeocercas.RowHeadersWidth = 51;
            gridGeocercas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridGeocercas.Size = new Size(325, 280);
            gridGeocercas.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(779, 127);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 33;
            label4.Text = "Nombre geocerca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(781, 69);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 31;
            label5.Text = "Selecciona la geocerca";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(779, 152);
            txtDescripcion.Margin = new Padding(3, 5, 3, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(323, 27);
            txtDescripcion.TabIndex = 28;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(951, 197);
            btnEliminar.Margin = new Padding(3, 5, 3, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 31);
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
            btnAgregar.Location = new Point(779, 197);
            btnAgregar.Margin = new Padding(3, 5, 3, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 31);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(11, 69);
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
            gMapControl1.Size = new Size(750, 585);
            gMapControl1.TabIndex = 25;
            gMapControl1.Zoom = 0D;
            // 
            // frmGeocercasEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(1129, 677);
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