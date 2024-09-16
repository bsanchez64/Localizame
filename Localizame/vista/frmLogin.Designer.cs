namespace Localizame.vista
{
    partial class frmLogin
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
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnSesionOn = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(57, 324);
            txtUsuario.Margin = new Padding(10);
            txtUsuario.MinimumSize = new Size(0, 50);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(453, 50);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(55, 433);
            txtPassword.Margin = new Padding(10);
            txtPassword.MinimumSize = new Size(0, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(455, 50);
            txtPassword.TabIndex = 1;
            // 
            // btnSesionOn
            // 
            btnSesionOn.BackColor = SystemColors.ActiveCaptionText;
            btnSesionOn.BackgroundImageLayout = ImageLayout.None;
            btnSesionOn.FlatAppearance.BorderSize = 0;
            btnSesionOn.FlatStyle = FlatStyle.Flat;
            btnSesionOn.Font = new Font("Segoe UI", 12F);
            btnSesionOn.ForeColor = Color.White;
            btnSesionOn.Location = new Point(53, 528);
            btnSesionOn.Name = "btnSesionOn";
            btnSesionOn.Size = new Size(468, 60);
            btnSesionOn.TabIndex = 2;
            btnSesionOn.Text = "Iniciar Sesion";
            btnSesionOn.UseVisualStyleBackColor = false;
            btnSesionOn.Click += btnSesionOn_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(522, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmLogin
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(565, 753);
            Controls.Add(btnCerrar);
            Controls.Add(btnSesionOn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnSesionOn;
        private Button btnCerrar;
    }
}