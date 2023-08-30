namespace ProveedoresUI
{
    public partial class frmProveedor : Form
    {
        protected int Proveedores = 4;

        public enum IndiceTextBox
        {
            ID,
            PROVEEDOR,
            TELEFONO,
            DIRECCION
        }
        public frmProveedor()
        {
            InitializeComponent();
        }

        public void BorrarControlesTextBox()
        {
            for(int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i];
                if(miControl is TextBox)
                {
                    miControl.Text = "";
                }
            }
        }

        public void EstablecerValoresControlesTextBox(string[] valores)
        {
            if (valores.Length != Proveedores)
            {
                throw (new ArgumentException("Debe Haber " + (Proveedores + 1) + " objetos string en el arreglo"));
            }
            else
            {
                txtId.Text = valores[(int) IndiceTextBox.ID];
                txtNombreProveedor.Text = valores[(int) IndiceTextBox.PROVEEDOR];
                txtTelefono.Text = valores[(int) IndiceTextBox.TELEFONO];
                txtDireccion.Text = valores[(int) IndiceTextBox.DIRECCION];
            }
        }

        public string[] ObtenerValoresControlesTextBox()
        {
            string[] valores = new string[Proveedores];

            valores[(int) IndiceTextBox.ID] = txtId.Text;
            valores[(int)IndiceTextBox.PROVEEDOR] = txtNombreProveedor.Text;
            valores[(int)IndiceTextBox.TELEFONO] = txtTelefono.Text;
            valores[(int)IndiceTextBox.DIRECCION] = txtDireccion.Text;

            return valores;
        }
    }
}