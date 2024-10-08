namespace Localizame.vista
{
    partial class frmOperadorEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperadorEditar));
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblEditar = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(12, 181);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(419, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(12, 139);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(419, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Editar operador";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtCedula
            // 
            txtCedula.Enabled = false;
            txtCedula.Location = new Point(16, 97);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(125, 27);
            txtCedula.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(157, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 74);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 6;
            label1.Text = "Cédula";
            // 
            // lblEditar
            // 
            lblEditar.AutoSize = true;
            lblEditar.BackColor = Color.Transparent;
            lblEditar.Font = new Font("Segoe UI", 12F);
            lblEditar.ForeColor = SystemColors.ControlLightLight;
            lblEditar.Location = new Point(12, 23);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(129, 28);
            lblEditar.TabIndex = 12;
            lblEditar.Text = "Editar cédula:";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(407, 13);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 30);
            btnCerrar.TabIndex = 15;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmOperadorEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(445, 226);
            Controls.Add(btnCerrar);
            Controls.Add(lblEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOperadorEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar operador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private Label label2;
        private Label label1;
        private Label lblEditar;
        private Button btnCerrar;
    }
}