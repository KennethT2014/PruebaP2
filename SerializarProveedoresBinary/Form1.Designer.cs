namespace SerializarProveedoresBinary
{
    partial class Form1
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
            btnGuardarArchivo = new Button();
            btnAgregarProveedor = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGuardarArchivo
            // 
            btnGuardarArchivo.Location = new Point(12, 538);
            btnGuardarArchivo.Name = "btnGuardarArchivo";
            btnGuardarArchivo.Size = new Size(177, 69);
            btnGuardarArchivo.TabIndex = 0;
            btnGuardarArchivo.Text = "Guardar proveedor";
            btnGuardarArchivo.UseVisualStyleBackColor = true;
            btnGuardarArchivo.Click += btnGuardarArchivo_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(195, 538);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(177, 69);
            btnAgregarProveedor.TabIndex = 1;
            btnAgregarProveedor.Text = "Agregar otro proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(378, 538);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(141, 69);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 619);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(btnGuardarArchivo);
            Name = "Form1";
            Text = "Agregar Proveedor";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardarArchivo;
        private Button btnAgregarProveedor;
        private Button btnSalir;
    }
}