namespace Localizame.vista
{
    partial class frmGeocercaEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeocercaEliminar));
            btnCerrar = new Button();
            btnAtras = new Button();
            label2 = new Label();
            gridGeocercas = new DataGridView();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            label5 = new Label();
            cbxGeocercas = new ComboBox();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridGeocercas).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(955, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
            btnCerrar.TabIndex = 11;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Black;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(12, 13);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(114, 23);
            btnAtras.TabIndex = 15;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(390, 12);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 16;
            label2.Text = "Eliminar geocercas";
            // 
            // gridGeocercas
            // 
            gridGeocercas.AllowUserToAddRows = false;
            gridGeocercas.AllowUserToDeleteRows = false;
            gridGeocercas.AllowUserToResizeColumns = false;
            gridGeocercas.AllowUserToResizeRows = false;
            gridGeocercas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridGeocercas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGeocercas.Location = new Point(692, 174);
            gridGeocercas.Name = "gridGeocercas";
            gridGeocercas.ReadOnly = true;
            gridGeocercas.RowHeadersVisible = false;
            gridGeocercas.RowHeadersWidth = 51;
            gridGeocercas.Size = new Size(284, 210);
            gridGeocercas.TabIndex = 35;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(12, 57);
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
            gMapControl1.TabIndex = 36;
            gMapControl1.Zoom = 0D;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(694, 88);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 37;
            label5.Text = "Selecciona la geocerca";
            // 
            // cbxGeocercas
            // 
            cbxGeocercas.FormattingEnabled = true;
            cbxGeocercas.Location = new Point(696, 105);
            cbxGeocercas.Margin = new Padding(3, 2, 3, 2);
            cbxGeocercas.Name = "cbxGeocercas";
            cbxGeocercas.Size = new Size(282, 23);
            cbxGeocercas.TabIndex = 38;
            cbxGeocercas.SelectedValueChanged += cbxGeocercas_SelectedValueChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(694, 144);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(283, 23);
            btnEliminar.TabIndex = 42;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmGeocercaEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 508);
            Controls.Add(btnEliminar);
            Controls.Add(cbxGeocercas);
            Controls.Add(label5);
            Controls.Add(gMapControl1);
            Controls.Add(gridGeocercas);
            Controls.Add(label2);
            Controls.Add(btnAtras);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGeocercaEliminar";
            Text = "frmGeocercaEliminar";
            MouseMove += frmGeocercaEliminar_MouseMove;
            ((System.ComponentModel.ISupportInitialize)gridGeocercas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnAtras;
        private Label label2;
        private DataGridView gridGeocercas;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Label label5;
        private ComboBox cbxGeocercas;
        private Button btnEliminar;
    }
}