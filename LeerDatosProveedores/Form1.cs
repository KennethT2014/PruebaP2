using ProveedoresUI;

namespace LeerDatosProveedores
{
    public partial class Form1 : Form
    {
        private FileStream entrada;
        private StreamReader archivoReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult result = selectorArchivo.ShowDialog();

            string nombreArchivo;
            if (result == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;

            if (nombreArchivo == "" || nombreArchivo == null)
            {
                MessageBox.Show("Nombre de archivo inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                entrada = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                archivoReader = new StreamReader(entrada);
                btnAbrirArchivo.Enabled = false;
                btnMostrar.Enabled = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Button emisorButton = (Button)sender;
            string tipoCuenta = emisorButton.Text;

            try
            {
                entrada.Seek(0, SeekOrigin.Begin);
                txtMostrarDatos.Text = "Las cuentas son: \r\n";
                while(true)
                {
                    Registro registro;

                    string registroEntrada = archivoReader.ReadLine();
                    string[] camposEntrada;
                    if (registroEntrada == null)
                        return;

                    camposEntrada = registroEntrada.Split(",");

                    registro = new Registro(camposEntrada[0], camposEntrada[1],
                        camposEntrada[2], camposEntrada[3]);

                    string salida = registro.Id + "\t" + registro.NombreProveedor + "\t" +
                        registro.NumeroTelefono + "\t" + registro.Direccion + "\t\r";

                    
                    txtMostrarDatos.Text += salida;
                }

            }
            catch (IOException)
            {
                MessageBox.Show("No se puede leer el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (entrada != null)
            {
                try
                {
                    entrada.Close();
                    archivoReader.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("No se puede cerrar el archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Application.Exit();
        }
    }
}