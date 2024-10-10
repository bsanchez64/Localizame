namespace Localizame.vista
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            label1 = new Label();
            btnCerrar = new Button();
            gridUsuarios = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            btnNuevoUs = new Button();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 7;
            label1.Text = "Gestión de usuarios";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(456, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 29);
            btnCerrar.TabIndex = 8;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.AllowUserToResizeColumns = false;
            gridUsuarios.AllowUserToResizeRows = false;
            gridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            gridUsuarios.Location = new Point(14, 57);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.ReadOnly = true;
            gridUsuarios.RowHeadersVisible = false;
            gridUsuarios.RowHeadersWidth = 51;
            gridUsuarios.Size = new Size(466, 369);
            gridUsuarios.TabIndex = 9;
            gridUsuarios.CellClick += gridUsuarios_CellClick;
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
            // btnNuevoUs
            // 
            btnNuevoUs.BackColor = SystemColors.ActiveCaptionText;
            btnNuevoUs.FlatStyle = FlatStyle.Popup;
            btnNuevoUs.ForeColor = SystemColors.ControlLightLight;
            btnNuevoUs.Location = new Point(11, 442);
            btnNuevoUs.Name = "btnNuevoUs";
            btnNuevoUs.Size = new Size(469, 29);
            btnNuevoUs.TabIndex = 10;
            btnNuevoUs.Text = "Nuevo usuario";
            btnNuevoUs.UseVisualStyleBackColor = false;
            btnNuevoUs.Click += btnNuevoVh_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(497, 489);
            Controls.Add(btnNuevoUs);
            Controls.Add(gridUsuarios);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de usuarios";
            Load += frmUsuarios_Load;
            MouseMove += frmUsuarios_MouseMove;
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCerrar;
        private DataGridView gridUsuarios;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private Button btnNuevoUs;
    }
}