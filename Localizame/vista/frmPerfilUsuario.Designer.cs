namespace Localizame.vista
{
    partial class frmPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilUsuario));
            label1 = new Label();
            btnCerrar = new Button();
            btnAtras = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtNombre = new TextBox();
            txtPw1 = new TextBox();
            txtPw2 = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Edita tu perfil";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(401, 17);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 27);
            btnCerrar.TabIndex = 5;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(12, 13);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(125, 31);
            btnAtras.TabIndex = 15;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 16;
            label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(216, 107);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 17;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 18;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(216, 179);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 19;
            label5.Text = "Verificar contraseña";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(185, 27);
            txtUserName.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(216, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 27);
            txtNombre.TabIndex = 21;
            // 
            // txtPw1
            // 
            txtPw1.Location = new Point(12, 202);
            txtPw1.Name = "txtPw1";
            txtPw1.Size = new Size(185, 27);
            txtPw1.TabIndex = 22;
            txtPw1.UseSystemPasswordChar = true;
            // 
            // txtPw2
            // 
            txtPw2.Location = new Point(216, 202);
            txtPw2.Name = "txtPw2";
            txtPw2.Size = new Size(209, 27);
            txtPw2.TabIndex = 23;
            txtPw2.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(12, 259);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(413, 29);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(437, 314);
            Controls.Add(btnGuardar);
            Controls.Add(txtPw2);
            Controls.Add(txtPw1);
            Controls.Add(txtNombre);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAtras);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPerfilUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar perfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCerrar;
        private Button btnAtras;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtNombre;
        private TextBox txtPw1;
        private TextBox txtPw2;
        private Button btnGuardar;
    }
}