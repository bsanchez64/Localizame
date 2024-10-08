namespace Localizame.vista
{
    partial class frmOperadorAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperadorAgregar));
            label1 = new Label();
            label2 = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnCerrar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(153, 52);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(12, 75);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(125, 27);
            txtCedula.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 27);
            txtNombre.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(12, 114);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(419, 31);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar operador";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(11, 162);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(419, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(406, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 30);
            btnCerrar.TabIndex = 13;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 14;
            label3.Text = "Operador nuevo";
            // 
            // frmOperadorAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backsolo;
            ClientSize = new Size(442, 207);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOperadorAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar operador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnCerrar;
        private Label label3;
    }
}