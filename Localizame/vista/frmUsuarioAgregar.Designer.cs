namespace Localizame.vista
{
    partial class frmUsuarioAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioAgregar));
            label1 = new Label();
            btnCerrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtNombre = new TextBox();
            cbxNivel = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 14;
            label1.Text = "Usuario nuevo";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(442, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 29);
            btnCerrar.TabIndex = 15;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(14, 67);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 16;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(126, 67);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(245, 67);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 18;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(358, 67);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 19;
            label5.Text = "Nivel";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(14, 93);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(105, 27);
            txtUsername.TabIndex = 20;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(111, 27);
            txtPassword.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(245, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(105, 27);
            txtNombre.TabIndex = 22;
            // 
            // cbxNivel
            // 
            cbxNivel.FormattingEnabled = true;
            cbxNivel.Items.AddRange(new object[] { "administrador", "usuario" });
            cbxNivel.Location = new Point(358, 93);
            cbxNivel.Name = "cbxNivel";
            cbxNivel.Size = new Size(108, 28);
            cbxNivel.TabIndex = 23;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(14, 141);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(451, 35);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(14, 181);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(449, 29);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmUsuarioAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(480, 221);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cbxNivel);
            Controls.Add(txtNombre);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsuarioAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar usuario";
            Load += frmUsuarioAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCerrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNombre;
        private ComboBox cbxNivel;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}