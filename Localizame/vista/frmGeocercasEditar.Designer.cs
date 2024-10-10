namespace Localizame.vista
{
    partial class frmGeocercasEditar
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
            cbxGeocercas = new ComboBox();
            SuspendLayout();
            // 
            // cbxGeocercas
            // 
            cbxGeocercas.FormattingEnabled = true;
            cbxGeocercas.Location = new Point(102, 46);
            cbxGeocercas.Name = "cbxGeocercas";
            cbxGeocercas.Size = new Size(151, 28);
            cbxGeocercas.TabIndex = 0;
            // 
            // frmGeocercasEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxGeocercas);
            Name = "frmGeocercasEditar";
            Text = "frmGeocercasEditar";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbxGeocercas;
    }
}