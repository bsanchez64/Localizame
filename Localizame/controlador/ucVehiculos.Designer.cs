namespace Localizame.controlador
{
    partial class ucVehiculos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            cbxVehiculos = new ComboBox();
            SuspendLayout();
            // 
            // cbxVehiculos
            // 
            cbxVehiculos.FormattingEnabled = true;
            cbxVehiculos.Location = new Point(8, 10);
            cbxVehiculos.Name = "cbxVehiculos";
            cbxVehiculos.Size = new Size(194, 28);
            cbxVehiculos.TabIndex = 0;
            cbxVehiculos.SelectedIndexChanged += cbxVehiculos_SelectedIndexChanged;
            // 
            // ucVehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbxVehiculos);
            Name = "ucVehiculos";
            Size = new Size(213, 48);
            Load += ucVehiculos_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbxVehiculos;
    }
}
