namespace Localizame.vista
{
    partial class frmOperadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperadores));
            gridOperadores = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            btnNuevoVh = new Button();
            label1 = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridOperadores).BeginInit();
            SuspendLayout();
            // 
            // gridOperadores
            // 
            gridOperadores.AllowUserToAddRows = false;
            gridOperadores.AllowUserToDeleteRows = false;
            gridOperadores.AllowUserToResizeColumns = false;
            gridOperadores.AllowUserToResizeRows = false;
            gridOperadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridOperadores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridOperadores.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            gridOperadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOperadores.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            gridOperadores.Location = new Point(11, 48);
            gridOperadores.Name = "gridOperadores";
            gridOperadores.ReadOnly = true;
            gridOperadores.RowHeadersVisible = false;
            gridOperadores.RowHeadersWidth = 51;
            gridOperadores.Size = new Size(506, 277);
            gridOperadores.TabIndex = 0;
            gridOperadores.CellClick += gridOperadores_CellClick;
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
            btnNuevoVh.Location = new Point(11, 339);
            btnNuevoVh.Name = "btnNuevoVh";
            btnNuevoVh.Size = new Size(506, 31);
            btnNuevoVh.TabIndex = 5;
            btnNuevoVh.Text = "Nuevo operador";
            btnNuevoVh.UseVisualStyleBackColor = false;
            btnNuevoVh.Click += btnNuevoVh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 8;
            label1.Text = "Gestión de operadores";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(493, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 30);
            btnCerrar.TabIndex = 7;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmOperadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(529, 390);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnNuevoVh);
            Controls.Add(gridOperadores);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOperadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión operadores";
            ((System.ComponentModel.ISupportInitialize)gridOperadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridOperadores;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private Button btnNuevoVh;
        private Label label1;
        private Button btnCerrar;
    }
}