namespace Localizame.vista
{
    partial class frmGeocercaVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeocercaVer));
            label2 = new Label();
            btnAtras = new Button();
            btnCerrar = new Button();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            label5 = new Label();
            cbxGeocercas = new ComboBox();
            btnVer = new Button();
            gridGeocercas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridGeocercas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(391, 9);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 17;
            label2.Text = "Ver geocercas";
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
            btnAtras.TabIndex = 18;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(939, 16);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
            btnCerrar.TabIndex = 19;
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
            gMapControl1.Location = new Point(12, 43);
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
            gMapControl1.Size = new Size(631, 414);
            gMapControl1.TabIndex = 37;
            gMapControl1.Zoom = 0D;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(663, 66);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 38;
            label5.Text = "Selecciona la geocerca";
            // 
            // cbxGeocercas
            // 
            cbxGeocercas.FormattingEnabled = true;
            cbxGeocercas.Location = new Point(663, 83);
            cbxGeocercas.Margin = new Padding(3, 2, 3, 2);
            cbxGeocercas.Name = "cbxGeocercas";
            cbxGeocercas.Size = new Size(282, 23);
            cbxGeocercas.TabIndex = 39;
            cbxGeocercas.SelectedIndexChanged += cbxGeocercas_SelectedIndexChanged;
            cbxGeocercas.SelectedValueChanged += cbxGeocercas_SelectedValueChanged;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.Black;
            btnVer.FlatStyle = FlatStyle.Popup;
            btnVer.ForeColor = Color.White;
            btnVer.Location = new Point(663, 122);
            btnVer.Margin = new Padding(3, 4, 3, 4);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(283, 23);
            btnVer.TabIndex = 43;
            btnVer.Text = "Ver todas las geocercas";
            btnVer.UseVisualStyleBackColor = false;
            // 
            // gridGeocercas
            // 
            gridGeocercas.AllowUserToAddRows = false;
            gridGeocercas.AllowUserToDeleteRows = false;
            gridGeocercas.AllowUserToResizeColumns = false;
            gridGeocercas.AllowUserToResizeRows = false;
            gridGeocercas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridGeocercas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGeocercas.Location = new Point(662, 168);
            gridGeocercas.Name = "gridGeocercas";
            gridGeocercas.ReadOnly = true;
            gridGeocercas.RowHeadersVisible = false;
            gridGeocercas.RowHeadersWidth = 51;
            gridGeocercas.Size = new Size(284, 210);
            gridGeocercas.TabIndex = 44;
            gridGeocercas.SelectionChanged += gridGeocercas_SelectionChanged;
            // 
            // frmGeocercaVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 469);
            Controls.Add(gridGeocercas);
            Controls.Add(btnVer);
            Controls.Add(cbxGeocercas);
            Controls.Add(label5);
            Controls.Add(gMapControl1);
            Controls.Add(btnCerrar);
            Controls.Add(btnAtras);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGeocercaVer";
            Text = "frmGeocercaVer";
            Load += frmGeocercaVer_Load;
            MouseMove += frmGeocercaVer_MouseMove;
            ((System.ComponentModel.ISupportInitialize)gridGeocercas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnAtras;
        private Button btnCerrar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Label label5;
        private ComboBox cbxGeocercas;
        private Button btnVer;
        private DataGridView gridGeocercas;
    }
}