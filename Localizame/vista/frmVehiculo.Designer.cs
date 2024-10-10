namespace Localizame.vista
{
    partial class frmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculo));
            gridVehiculos = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            btnNuevoVh = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridVehiculos).BeginInit();
            SuspendLayout();
            // 
            // gridVehiculos
            // 
            gridVehiculos.AllowUserToAddRows = false;
            gridVehiculos.AllowUserToDeleteRows = false;
            gridVehiculos.AllowUserToResizeColumns = false;
            gridVehiculos.AllowUserToResizeRows = false;
            gridVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridVehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridVehiculos.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            gridVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVehiculos.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            gridVehiculos.Location = new Point(12, 60);
            gridVehiculos.Name = "gridVehiculos";
            gridVehiculos.ReadOnly = true;
            gridVehiculos.RowHeadersVisible = false;
            gridVehiculos.RowHeadersWidth = 51;
            gridVehiculos.Size = new Size(468, 384);
            gridVehiculos.TabIndex = 3;
            gridVehiculos.CellClick += gridVehiculos_CellClick;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.editar1;
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Width = 54;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.borrar1;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 69;
            // 
            // btnNuevoVh
            // 
            btnNuevoVh.BackColor = SystemColors.ActiveCaptionText;
            btnNuevoVh.FlatStyle = FlatStyle.Popup;
            btnNuevoVh.ForeColor = SystemColors.ControlLightLight;
            btnNuevoVh.Location = new Point(12, 460);
            btnNuevoVh.Name = "btnNuevoVh";
            btnNuevoVh.Size = new Size(468, 29);
            btnNuevoVh.TabIndex = 4;
            btnNuevoVh.Text = "Nuevo vehículo";
            btnNuevoVh.UseVisualStyleBackColor = false;
            btnNuevoVh.Click += btnNuevoVh_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(456, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 30);
            btnCerrar.TabIndex = 5;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 6;
            label1.Text = "Gestión de vehículos";
            // 
            // frmVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(492, 502);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnNuevoVh);
            Controls.Add(gridVehiculos);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de vehículos";
            Load += frmVehiculo_Load;
            MouseMove += frmVehiculo_MouseMove;
            ((System.ComponentModel.ISupportInitialize)gridVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView gridVehiculos;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private Button btnNuevoVh;
        private Button btnCerrar;
        private Label label1;
    }
}