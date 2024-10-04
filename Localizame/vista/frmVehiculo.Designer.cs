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
            gridVehiculos.Location = new Point(12, 12);
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
            // frmVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 408);
            Controls.Add(gridVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVehiculo";
            Text = "Gestion de vehículos";
            Load += frmVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)gridVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView gridVehiculos;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}