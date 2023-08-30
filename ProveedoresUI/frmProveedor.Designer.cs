namespace ProveedoresUI
{
    partial class frmProveedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Proveedor";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombreProveedor.Location = new System.Drawing.Point(81, 156);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(289, 23);
            this.txtNombreProveedor.TabIndex = 1;
            this.txtNombreProveedor.Text = "Nombre del Proveedor";
            this.txtNombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefono.Location = new System.Drawing.Point(81, 223);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(289, 23);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.Text = "Número de teléfono";
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDireccion.Location = new System.Drawing.Point(81, 288);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(289, 77);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.Text = "Dirección";
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtId.Location = new System.Drawing.Point(182, 92);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 4;
            this.txtId.Text = "Proveedor";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.label1);
            this.Name = "frmProveedor";
            this.Text = "biblioteca de proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNombreProveedor;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtId;
    }
}