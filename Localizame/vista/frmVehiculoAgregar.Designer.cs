namespace Localizame.vista
{
    partial class frmVehiculoAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculoAgregar));
            btnCancelar = new Button();
            cbxPropietario = new ComboBox();
            btnGuardar = new Button();
            txtPlaca = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(9, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(449, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbxPropietario
            // 
            cbxPropietario.FormattingEnabled = true;
            cbxPropietario.Location = new Point(234, 78);
            cbxPropietario.Name = "cbxPropietario";
            cbxPropietario.Size = new Size(225, 28);
            cbxPropietario.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(9, 121);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(451, 35);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(12, 78);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(203, 27);
            txtPlaca.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(234, 55);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 11;
            label3.Text = "Propietario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 10;
            label2.Text = "Placa";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(436, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 30);
            btnCerrar.TabIndex = 12;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 13;
            label1.Text = "Vehículos nuevo";
            // 
            // frmVehiculoAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(475, 221);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnCancelar);
            Controls.Add(cbxPropietario);
            Controls.Add(btnGuardar);
            Controls.Add(txtPlaca);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVehiculoAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo vehículo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private ComboBox cbxPropietario;
        private Button btnGuardar;
        private TextBox txtPlaca;
        private Label label3;
        private Label label2;
        private Button btnCerrar;
        private Label label1;
    }
}