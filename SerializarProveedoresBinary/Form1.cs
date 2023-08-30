using ProveedoresUI;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializarProveedoresBinary
{
    [Serializable]
    public partial class Form1 : frmProveedor
    {
        private BinaryFormatter aplicadorFormato = new BinaryFormatter();
        private FileStream salida;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreArchivo;

            selectorArchivo.CheckFileExists = false;

            if (resultado == DialogResult.Cancel) { return; }

            nombreArchivo = selectorArchivo.FileName;

            if (nombreArchivo == "" || nombreArchivo == null)
            {
                MessageBox.Show("Nombre de archivo inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                    btnGuardarArchivo.Enabled = false;
                    btnAgregarProveedor.Enabled = true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error al abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresControlesTextBox();
            RegistroSerializable registro = new RegistroSerializable();

            if (valores[(int)IndiceTextBox.ID] != "")
            {
                try
                {
                    if (registro.Id != null)
                    {

                        registro.Id = valores[(int)IndiceTextBox.ID];
                        registro.Proveedor = valores[(int)IndiceTextBox.PROVEEDOR];
                        registro.Telefono = valores[(int)IndiceTextBox.TELEFONO];
                        registro.Direccion = valores[(int)IndiceTextBox.DIRECCION];

                        aplicadorFormato.Serialize(salida, registro);
                    }                
                    else
                    {
                        MessageBox.Show("Numero de cuenta inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error al escribir en el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            BorrarControlesTextBox();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (salida != null)
            {
                try
                {
                    salida.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("No se puede cerrar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Application.Exit();
        }
    }
}