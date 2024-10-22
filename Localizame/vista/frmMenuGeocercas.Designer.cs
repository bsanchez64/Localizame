namespace Localizame.vista
{
    partial class frmMenuGeocercas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuGeocercas));
            label1 = new Label();
            btnCerrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pnlVerGeocercas = new Panel();
            pnlAddGeocercas = new Panel();
            pnlEditGeocerca = new Panel();
            pnlDeleteGeo = new Panel();
            btnAtras = new Button();
            pnlVerGeocercas.SuspendLayout();
            pnlAddGeocercas.SuspendLayout();
            pnlEditGeocerca.SuspendLayout();
            pnlDeleteGeo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 131);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Ver Geocercas";
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(844, 9);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
            btnCerrar.TabIndex = 5;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(30, 121);
            label2.Name = "label2";
            label2.Size = new Size(87, 42);
            label2.TabIndex = 6;
            label2.Text = "Agregar\r\nGeocercas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(31, 121);
            label3.Name = "label3";
            label3.Size = new Size(87, 42);
            label3.TabIndex = 7;
            label3.Text = "Editar\r\nGeocercas";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(38, 121);
            label4.Name = "label4";
            label4.Size = new Size(87, 42);
            label4.TabIndex = 8;
            label4.Text = "Eliminar\r\nGeocercas";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlVerGeocercas
            // 
            pnlVerGeocercas.BackColor = Color.Transparent;
            pnlVerGeocercas.Controls.Add(label1);
            pnlVerGeocercas.Cursor = Cursors.Hand;
            pnlVerGeocercas.Location = new Point(62, 218);
            pnlVerGeocercas.Name = "pnlVerGeocercas";
            pnlVerGeocercas.Size = new Size(150, 243);
            pnlVerGeocercas.TabIndex = 9;
            pnlVerGeocercas.MouseLeave += pnlVerGeocercas_MouseLeave;
            pnlVerGeocercas.MouseHover += pnlVerGeocercas_MouseHover;
            // 
            // pnlAddGeocercas
            // 
            pnlAddGeocercas.BackColor = Color.Transparent;
            pnlAddGeocercas.Controls.Add(label2);
            pnlAddGeocercas.Cursor = Cursors.Hand;
            pnlAddGeocercas.Location = new Point(257, 218);
            pnlAddGeocercas.Name = "pnlAddGeocercas";
            pnlAddGeocercas.Size = new Size(159, 243);
            pnlAddGeocercas.TabIndex = 10;
            pnlAddGeocercas.MouseClick += pnlAddGeocercas_MouseClick;
            pnlAddGeocercas.MouseLeave += pnlAddGeocercas_MouseLeave;
            pnlAddGeocercas.MouseHover += pnlAddGeocercas_MouseHover;
            // 
            // pnlEditGeocerca
            // 
            pnlEditGeocerca.BackColor = Color.Transparent;
            pnlEditGeocerca.Controls.Add(label3);
            pnlEditGeocerca.Cursor = Cursors.Hand;
            pnlEditGeocerca.Location = new Point(462, 218);
            pnlEditGeocerca.Name = "pnlEditGeocerca";
            pnlEditGeocerca.Size = new Size(159, 243);
            pnlEditGeocerca.TabIndex = 11;
            pnlEditGeocerca.MouseLeave += pnlEditGeocerca_MouseLeave;
            pnlEditGeocerca.MouseHover += pnlEditGeocerca_MouseHover;
            // 
            // pnlDeleteGeo
            // 
            pnlDeleteGeo.BackColor = Color.Transparent;
            pnlDeleteGeo.Controls.Add(label4);
            pnlDeleteGeo.Cursor = Cursors.Hand;
            pnlDeleteGeo.Location = new Point(656, 218);
            pnlDeleteGeo.Name = "pnlDeleteGeo";
            pnlDeleteGeo.Size = new Size(163, 243);
            pnlDeleteGeo.TabIndex = 12;
            pnlDeleteGeo.Click += pnlDeleteGeo_Click;
            pnlDeleteGeo.MouseLeave += pnlDeleteGeo_MouseLeave;
            pnlDeleteGeo.MouseHover += pnlDeleteGeo_MouseHover;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(12, 9);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(93, 23);
            btnAtras.TabIndex = 13;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // frmMenuGeocercas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.frmMenuGeocercas;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(875, 518);
            Controls.Add(btnAtras);
            Controls.Add(pnlVerGeocercas);
            Controls.Add(btnCerrar);
            Controls.Add(pnlAddGeocercas);
            Controls.Add(pnlEditGeocerca);
            Controls.Add(pnlDeleteGeo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenuGeocercas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión De Geocercas";
            Load += frmMenuGeocercas_Load;
            MouseMove += frmMenuGeocercas_MouseMove;
            pnlVerGeocercas.ResumeLayout(false);
            pnlVerGeocercas.PerformLayout();
            pnlAddGeocercas.ResumeLayout(false);
            pnlAddGeocercas.PerformLayout();
            pnlEditGeocerca.ResumeLayout(false);
            pnlEditGeocerca.PerformLayout();
            pnlDeleteGeo.ResumeLayout(false);
            pnlDeleteGeo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnCerrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel pnlVerGeocercas;
        private Panel pnlAddGeocercas;
        private Panel pnlEditGeocerca;
        private Panel pnlDeleteGeo;
        private Button btnAtras;
    }
}