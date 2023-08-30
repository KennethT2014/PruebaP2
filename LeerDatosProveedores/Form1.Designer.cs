namespace LeerDatosProveedores
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
            btnAbrirArchivo = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            txtMostrarDatos = new TextBox();
            SuspendLayout();
            // 
            // btnAbrirArchivo
            // 
            btnAbrirArchivo.Location = new Point(14, 566);
            btnAbrirArchivo.Margin = new Padding(3, 4, 3, 4);
            btnAbrirArchivo.Name = "btnAbrirArchivo";
            btnAbrirArchivo.Size = new Size(137, 55);
            btnAbrirArchivo.TabIndex = 0;
            btnAbrirArchivo.Text = "Abrir Archivo";
            btnAbrirArchivo.UseVisualStyleBackColor = true;
            btnAbrirArchivo.Click += btnAbrirArchivo_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(221, 569);
            btnMostrar.Margin = new Padding(3, 4, 3, 4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(140, 55);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Proveedores";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnSiguiente_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(446, 566);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 55);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtMostrarDatos
            // 
            txtMostrarDatos.Location = new Point(14, 12);
            txtMostrarDatos.Multiline = true;
            txtMostrarDatos.Name = "txtMostrarDatos";
            txtMostrarDatos.Size = new Size(572, 547);
            txtMostrarDatos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 637);
            Controls.Add(txtMostrarDatos);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnAbrirArchivo);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            Text = "Leer Datos de los Proveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirArchivo;
        private Button btnMostrar;
        private Button btnSalir;
        private TextBox txtMostrarDatos;
    }
}