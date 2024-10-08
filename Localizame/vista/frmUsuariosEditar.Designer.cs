namespace Localizame.vista
{
    partial class frmUsuariosEditar
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
            lblUsuario = new Label();
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtUsername = new TextBox();
            cbxNivel = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(115, 21);
            lblUsuario.TabIndex = 16;
            lblUsuario.Text = "Editar Usuario: ";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(458, 8);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 22);
            btnCerrar.TabIndex = 17;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(11, 50);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 50);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(173, 50);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 21;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(328, 50);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 22;
            label5.Text = "Nivel";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(51, 77);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(116, 23);
            txtNombre.TabIndex = 23;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(173, 77);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(138, 23);
            txtUsername.TabIndex = 25;
            txtUsername.TextChanged += textBox2_TextChanged;
            // 
            // cbxNivel
            // 
            cbxNivel.FormattingEnabled = true;
            cbxNivel.Items.AddRange(new object[] { "administrador", "usuario" });
            cbxNivel.Location = new Point(328, 77);
            cbxNivel.Margin = new Padding(3, 2, 3, 2);
            cbxNivel.Name = "cbxNivel";
            cbxNivel.Size = new Size(151, 23);
            cbxNivel.TabIndex = 26;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(2, 104);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(477, 26);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaptionText;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(2, 134);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(477, 26);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 50);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 29;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(2, 77);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(34, 23);
            txtId.TabIndex = 30;
            // 
            // frmUsuariosEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(491, 171);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cbxNivel);
            Controls.Add(txtUsername);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuariosEditar";
            Text = "frmUsuariosEditar";
            Load += frmUsuariosEditar_Load;
            MouseClick += frmUsuariosEditar_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox textBox1;
        private TextBox txtUsername;
        private ComboBox cbxNivel;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label6;
        private TextBox txtId;
    }
}