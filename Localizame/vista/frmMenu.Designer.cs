namespace Localizame.vista
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            btnCerrar = new Button();
            pnlGestionSoft = new Panel();
            lblUserPlat = new Label();
            pnlGestionRuta = new Panel();
            lblGestion = new Label();
            pnlGeocercas = new Panel();
            label1 = new Label();
            pnlInformes = new Panel();
            label2 = new Label();
            lblBienvenido = new Label();
            pnlGestionSoft.SuspendLayout();
            pnlGestionRuta.SuspendLayout();
            pnlGeocercas.SuspendLayout();
            pnlInformes.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(875, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 27);
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlGestionSoft
            // 
            pnlGestionSoft.BackColor = Color.Transparent;
            pnlGestionSoft.Controls.Add(lblUserPlat);
            pnlGestionSoft.Cursor = Cursors.Hand;
            pnlGestionSoft.Location = new Point(57, 210);
            pnlGestionSoft.Margin = new Padding(3, 4, 3, 4);
            pnlGestionSoft.Name = "pnlGestionSoft";
            pnlGestionSoft.Size = new Size(174, 251);
            pnlGestionSoft.TabIndex = 5;
            pnlGestionSoft.MouseClick += pnlGestionSoft_MouseClick;
            pnlGestionSoft.MouseLeave += pnlGestionSoft_MouseLeave;
            pnlGestionSoft.MouseHover += pnlGestionSoft_MouseHover;
            // 
            // lblUserPlat
            // 
            lblUserPlat.AutoSize = true;
            lblUserPlat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserPlat.ForeColor = SystemColors.Control;
            lblUserPlat.Location = new Point(49, 130);
            lblUserPlat.Name = "lblUserPlat";
            lblUserPlat.Size = new Size(72, 31);
            lblUserPlat.TabIndex = 0;
            lblUserPlat.Text = "Perfil";
            // 
            // pnlGestionRuta
            // 
            pnlGestionRuta.BackColor = Color.Transparent;
            pnlGestionRuta.Controls.Add(lblGestion);
            pnlGestionRuta.Cursor = Cursors.Hand;
            pnlGestionRuta.Location = new Point(267, 210);
            pnlGestionRuta.Margin = new Padding(3, 4, 3, 4);
            pnlGestionRuta.Name = "pnlGestionRuta";
            pnlGestionRuta.Size = new Size(170, 251);
            pnlGestionRuta.TabIndex = 6;
            pnlGestionRuta.MouseClick += pnlGestionRuta_MouseClick;
            pnlGestionRuta.MouseLeave += pnlGestionRuta_MouseLeave;
            pnlGestionRuta.MouseHover += pnlGestionRuta_MouseHover;
            // 
            // lblGestion
            // 
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestion.ForeColor = SystemColors.Control;
            lblGestion.Location = new Point(33, 127);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(128, 62);
            lblGestion.TabIndex = 0;
            lblGestion.Text = "Gestión de\r\nRutas";
            lblGestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlGeocercas
            // 
            pnlGeocercas.BackColor = Color.Transparent;
            pnlGeocercas.Controls.Add(label1);
            pnlGeocercas.Cursor = Cursors.Hand;
            pnlGeocercas.Location = new Point(474, 210);
            pnlGeocercas.Margin = new Padding(3, 4, 3, 4);
            pnlGeocercas.Name = "pnlGeocercas";
            pnlGeocercas.Size = new Size(168, 251);
            pnlGeocercas.TabIndex = 6;
            pnlGeocercas.MouseClick += pnlGeocercas_MouseClick;
            pnlGeocercas.MouseLeave += pnlGeocercas_MouseLeave;
            pnlGeocercas.MouseHover += pnlGeocercas_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 127);
            label1.Name = "label1";
            label1.Size = new Size(128, 62);
            label1.TabIndex = 0;
            label1.Text = "Gestión de\r\nGeocercas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInformes
            // 
            pnlInformes.BackColor = Color.Transparent;
            pnlInformes.Controls.Add(label2);
            pnlInformes.Cursor = Cursors.Hand;
            pnlInformes.Location = new Point(687, 210);
            pnlInformes.Margin = new Padding(3, 4, 3, 4);
            pnlInformes.Name = "pnlInformes";
            pnlInformes.Size = new Size(164, 251);
            pnlInformes.TabIndex = 7;
            pnlInformes.MouseLeave += pnlInformes_MouseLeave;
            pnlInformes.MouseHover += pnlInformes_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(36, 144);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 0;
            label2.Text = "Informes";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.Font = new Font("Segoe UI", 16F);
            lblBienvenido.ForeColor = Color.White;
            lblBienvenido.Location = new Point(57, 131);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(149, 37);
            lblBienvenido.TabIndex = 8;
            lblBienvenido.Text = "Bienvenido";
            lblBienvenido.Click += lblBienvenido_Click;
            // 
            // frmMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.backMenu1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 519);
            Controls.Add(pnlInformes);
            Controls.Add(pnlGeocercas);
            Controls.Add(pnlGestionRuta);
            Controls.Add(pnlGestionSoft);
            Controls.Add(lblBienvenido);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmMenu";
            Load += frmMenu_Load;
            MouseMove += frmMenu_MouseMove;
            pnlGestionSoft.ResumeLayout(false);
            pnlGestionSoft.PerformLayout();
            pnlGestionRuta.ResumeLayout(false);
            pnlGestionRuta.PerformLayout();
            pnlGeocercas.ResumeLayout(false);
            pnlGeocercas.PerformLayout();
            pnlInformes.ResumeLayout(false);
            pnlInformes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Panel pnlGestionSoft;
        private Panel pnlGestionRuta;
        private Panel pnlGeocercas;
        private Panel pnlInformes;
        private Label lblBienvenido;
        private Label lblUserPlat;
        private Label lblGestion;
        private Label label1;
        private Label label2;
    }
}