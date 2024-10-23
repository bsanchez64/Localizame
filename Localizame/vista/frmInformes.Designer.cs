namespace Localizame.vista
{
    partial class frmInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformes));
            pnlInforme1 = new Panel();
            label1 = new Label();
            pnlInforme2 = new Panel();
            label2 = new Label();
            btnCerrar = new Button();
            btnAtras = new Button();
            pnlInforme1.SuspendLayout();
            pnlInforme2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInforme1
            // 
            pnlInforme1.BackColor = Color.Transparent;
            pnlInforme1.Controls.Add(label1);
            pnlInforme1.Cursor = Cursors.Hand;
            pnlInforme1.Location = new Point(166, 212);
            pnlInforme1.Margin = new Padding(3, 4, 3, 4);
            pnlInforme1.Name = "pnlInforme1";
            pnlInforme1.Size = new Size(163, 251);
            pnlInforme1.TabIndex = 7;
            pnlInforme1.MouseClick += pnlInforme1_MouseClick;
            pnlInforme1.MouseLeave += pnlInforme1_MouseLeave;
            pnlInforme1.MouseHover += pnlInforme1_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 127);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Informe 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInforme2
            // 
            pnlInforme2.BackColor = Color.Transparent;
            pnlInforme2.Controls.Add(label2);
            pnlInforme2.Cursor = Cursors.Hand;
            pnlInforme2.Location = new Point(372, 212);
            pnlInforme2.Margin = new Padding(3, 4, 3, 4);
            pnlInforme2.Name = "pnlInforme2";
            pnlInforme2.Size = new Size(163, 251);
            pnlInforme2.TabIndex = 8;
            pnlInforme2.MouseLeave += pnlInforme2_MouseLeave;
            pnlInforme2.MouseHover += pnlInforme2_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(32, 127);
            label2.Name = "label2";
            label2.Size = new Size(107, 50);
            label2.TabIndex = 0;
            label2.Text = "Gestión de\r\nGeocercas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(878, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 20);
            btnCerrar.TabIndex = 11;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Black;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(12, 13);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(111, 23);
            btnAtras.TabIndex = 15;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 519);
            Controls.Add(btnAtras);
            Controls.Add(btnCerrar);
            Controls.Add(pnlInforme2);
            Controls.Add(pnlInforme1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInformes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informes";
            pnlInforme1.ResumeLayout(false);
            pnlInforme1.PerformLayout();
            pnlInforme2.ResumeLayout(false);
            pnlInforme2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInforme1;
        private Label label1;
        private Panel pnlInforme2;
        private Label label2;
        private Button btnCerrar;
        private Button btnAtras;
    }
}