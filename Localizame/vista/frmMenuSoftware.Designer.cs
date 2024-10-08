﻿namespace Localizame.vista
{
    partial class frmMenuSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuSoftware));
            btnCerrar = new Button();
            pnlUsuarios = new Panel();
            label2 = new Label();
            pnlVehiculos = new Panel();
            label1 = new Label();
            pnlOperadores = new Panel();
            label3 = new Label();
            btnAtras = new Button();
            pnlUsuarios.SuspendLayout();
            pnlVehiculos.SuspendLayout();
            pnlOperadores.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(944, 15);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 27);
            btnCerrar.TabIndex = 6;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = Color.Transparent;
            pnlUsuarios.Controls.Add(label2);
            pnlUsuarios.Cursor = Cursors.Hand;
            pnlUsuarios.Location = new Point(176, 265);
            pnlUsuarios.Margin = new Padding(3, 4, 3, 4);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(182, 301);
            pnlUsuarios.TabIndex = 11;
            pnlUsuarios.MouseClick += pnlUsuarios_MouseClick;
            pnlUsuarios.MouseLeave += pnlUsuarios_MouseLeave;
            pnlUsuarios.MouseHover += pnlUsuarios_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(40, 152);
            label2.Name = "label2";
            label2.Size = new Size(117, 56);
            label2.TabIndex = 6;
            label2.Text = "Usuarios\r\nPlataforma";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlVehiculos
            // 
            pnlVehiculos.BackColor = Color.Transparent;
            pnlVehiculos.Controls.Add(label1);
            pnlVehiculos.Cursor = Cursors.Hand;
            pnlVehiculos.Location = new Point(401, 265);
            pnlVehiculos.Margin = new Padding(3, 4, 3, 4);
            pnlVehiculos.Name = "pnlVehiculos";
            pnlVehiculos.Size = new Size(182, 301);
            pnlVehiculos.TabIndex = 12;
            pnlVehiculos.MouseClick += pnlVehiculos_MouseClick;
            pnlVehiculos.MouseLeave += pnlVehiculos_MouseLeave;
            pnlVehiculos.MouseHover += pnlVehiculos_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(40, 152);
            label1.Name = "label1";
            label1.Size = new Size(117, 56);
            label1.TabIndex = 6;
            label1.Text = "Vehiculos\r\nPlataforma";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOperadores
            // 
            pnlOperadores.BackColor = Color.Transparent;
            pnlOperadores.Controls.Add(label3);
            pnlOperadores.Cursor = Cursors.Hand;
            pnlOperadores.Location = new Point(622, 265);
            pnlOperadores.Margin = new Padding(3, 4, 3, 4);
            pnlOperadores.Name = "pnlOperadores";
            pnlOperadores.Size = new Size(182, 301);
            pnlOperadores.TabIndex = 13;
            pnlOperadores.MouseClick += pnlOperadores_MouseClick;
            pnlOperadores.MouseLeave += pnlOperadores_MouseLeave;
            pnlOperadores.MouseHover += pnlOperadores_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(40, 152);
            label3.Name = "label3";
            label3.Size = new Size(121, 56);
            label3.TabIndex = 6;
            label3.Text = "Vehiculos\r\nOperadores";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveCaptionText;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(14, 13);
            btnAtras.Margin = new Padding(3, 4, 3, 4);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(125, 31);
            btnAtras.TabIndex = 14;
            btnAtras.Text = "< Volver atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // frmMenuSoftware
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.frmMenuSoftware;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 639);
            Controls.Add(btnAtras);
            Controls.Add(pnlOperadores);
            Controls.Add(pnlVehiculos);
            Controls.Add(pnlUsuarios);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenuSoftware";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de software";
            MouseMove += frmMenuSoftware_MouseMove;
            pnlUsuarios.ResumeLayout(false);
            pnlUsuarios.PerformLayout();
            pnlVehiculos.ResumeLayout(false);
            pnlVehiculos.PerformLayout();
            pnlOperadores.ResumeLayout(false);
            pnlOperadores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
        private Panel pnlUsuarios;
        private Label label2;
        private Panel pnlVehiculos;
        private Label label1;
        private Panel pnlOperadores;
        private Label label3;
        private Button btnAtras;
    }
}