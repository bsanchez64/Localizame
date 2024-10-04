namespace Localizame.vista
{
    partial class frmVehiculoEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculoEditar));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtPlaca = new TextBox();
            btnGuardar = new Button();
            cbxPropietario = new ComboBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Placa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 9);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Propietario";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(12, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(66, 27);
            txtId.TabIndex = 3;
            // 
            // txtPlaca
            // 
            txtPlaca.Enabled = false;
            txtPlaca.Location = new Point(93, 32);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(125, 27);
            txtPlaca.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 75);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(451, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxPropietario
            // 
            cbxPropietario.FormattingEnabled = true;
            cbxPropietario.Location = new Point(237, 32);
            cbxPropietario.Name = "cbxPropietario";
            cbxPropietario.Size = new Size(225, 28);
            cbxPropietario.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 125);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(449, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmVehiculoEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(473, 166);
            Controls.Add(btnCancelar);
            Controls.Add(cbxPropietario);
            Controls.Add(btnGuardar);
            Controls.Add(txtPlaca);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVehiculoEditar";
            Text = "Editar Vehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtPlaca;
        private Button btnGuardar;
        private ComboBox cbxPropietario;
        private Button btnCancelar;
    }
}