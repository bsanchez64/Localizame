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
            pnlGestionRuta = new Panel();
            pnlGeocercas = new Panel();
            pnlInformes = new Panel();
            lblBienvenido = new Label();
            pnlUser = new Panel();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(662, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 27);
            btnCerrar.TabIndex = 4;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlGestionSoft
            // 
            pnlGestionSoft.BackColor = Color.Transparent;
            pnlGestionSoft.Cursor = Cursors.Hand;
            pnlGestionSoft.Location = new Point(33, 158);
            pnlGestionSoft.Margin = new Padding(3, 4, 3, 4);
            pnlGestionSoft.Name = "pnlGestionSoft";
            pnlGestionSoft.Size = new Size(139, 216);
            pnlGestionSoft.TabIndex = 5;
            pnlGestionSoft.MouseLeave += pnlGestionSoft_MouseLeave;
            pnlGestionSoft.MouseHover += pnlGestionSoft_MouseHover;
            // 
            // pnlGestionRuta
            // 
            pnlGestionRuta.BackColor = Color.Transparent;
            pnlGestionRuta.Cursor = Cursors.Hand;
            pnlGestionRuta.Location = new Point(202, 158);
            pnlGestionRuta.Margin = new Padding(3, 4, 3, 4);
            pnlGestionRuta.Name = "pnlGestionRuta";
            pnlGestionRuta.Size = new Size(143, 216);
            pnlGestionRuta.TabIndex = 6;
            pnlGestionRuta.MouseClick += pnlGestionRuta_MouseClick;
            pnlGestionRuta.MouseLeave += pnlGestionRuta_MouseLeave;
            pnlGestionRuta.MouseHover += pnlGestionRuta_MouseHover;
            // 
            // pnlGeocercas
            // 
            pnlGeocercas.BackColor = Color.Transparent;
            pnlGeocercas.Cursor = Cursors.Hand;
            pnlGeocercas.Location = new Point(373, 158);
            pnlGeocercas.Margin = new Padding(3, 4, 3, 4);
            pnlGeocercas.Name = "pnlGeocercas";
            pnlGeocercas.Size = new Size(136, 216);
            pnlGeocercas.TabIndex = 6;
            pnlGeocercas.MouseClick += pnlGeocercas_MouseClick;
            pnlGeocercas.MouseLeave += pnlGeocercas_MouseLeave;
            pnlGeocercas.MouseHover += pnlGeocercas_MouseHover;
            // 
            // pnlInformes
            // 
            pnlInformes.BackColor = Color.Transparent;
            pnlInformes.Cursor = Cursors.Hand;
            pnlInformes.Location = new Point(534, 158);
            pnlInformes.Margin = new Padding(3, 4, 3, 4);
            pnlInformes.Name = "pnlInformes";
            pnlInformes.Size = new Size(140, 216);
            pnlInformes.TabIndex = 7;
            pnlInformes.MouseLeave += pnlInformes_MouseLeave;
            pnlInformes.MouseHover += pnlInformes_MouseHover;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.Font = new Font("Segoe UI", 16F);
            lblBienvenido.ForeColor = Color.White;
            lblBienvenido.Location = new Point(33, 93);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(149, 37);
            lblBienvenido.TabIndex = 8;
            lblBienvenido.Text = "Bienvenido";
            // 
            // pnlUser
            // 
            pnlUser.BackColor = Color.Transparent;
            pnlUser.BackgroundImage = Properties.Resources.user;
            pnlUser.BackgroundImageLayout = ImageLayout.Zoom;
            pnlUser.Cursor = Cursors.Hand;
            pnlUser.Location = new Point(612, 13);
            pnlUser.Margin = new Padding(3, 4, 3, 4);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(43, 27);
            pnlUser.TabIndex = 9;
            pnlUser.Tag = "";
            // 
            // frmMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(700, 400);
            Controls.Add(pnlUser);
            Controls.Add(lblBienvenido);
            Controls.Add(pnlInformes);
            Controls.Add(pnlGeocercas);
            Controls.Add(pnlGestionRuta);
            Controls.Add(pnlGestionSoft);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenu";
            Load += frmMenu_Load;
            MouseMove += frmMenu_MouseMove;
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
        private Panel pnlUser;
    }
}