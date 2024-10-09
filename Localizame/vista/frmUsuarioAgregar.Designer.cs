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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 14;
            label1.Text = "Usuario nuevo";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(387, 11);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 22);
            btnCerrar.TabIndex = 15;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 16;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(110, 50);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(214, 50);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 18;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(313, 50);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 19;
            label5.Text = "Nivel";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 70);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(92, 23);
            txtUsername.TabIndex = 20;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(110, 70);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(98, 23);
            txtPassword.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(214, 70);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(92, 23);
            txtNombre.TabIndex = 22;
            // 
            // cbxNivel
            // 
            cbxNivel.FormattingEnabled = true;
            cbxNivel.Items.AddRange(new object[] { "administrador", "usuario" });
            cbxNivel.Location = new Point(313, 70);
            cbxNivel.Margin = new Padding(3, 2, 3, 2);
            cbxNivel.Name = "cbxNivel";
            cbxNivel.Size = new Size(95, 23);
            cbxNivel.TabIndex = 23;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(12, 106);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(395, 26);
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
            btnCancelar.Location = new Point(12, 136);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(393, 22);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmUsuarioAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(420, 166);
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
            Name = "frmUsuarioAgregar";
            Text = "frmUsuarioAgregar";
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