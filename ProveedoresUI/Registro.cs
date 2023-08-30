using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveedoresUI
{
    public class Registro
    {
        private string id;
        private string nombreProveedor;
        private string numeroTelefono;
        private string direccion;

        public Registro() : this("", "", "", "")
        {

        }

        public Registro(string valorid, string valorNombreProveedor, string valorNumeroTelefono, string valorDireccion)
        {
            Id = valorid;
            NombreProveedor = valorNombreProveedor;
            NumeroTelefono = valorNumeroTelefono;
            Direccion = valorDireccion;
        }

        public string Id { get { return id; } set { id = value; } }
        public string NombreProveedor { get { return nombreProveedor; } set { nombreProveedor = value; } }
        public string NumeroTelefono { get { return numeroTelefono; } set { numeroTelefono = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
    }
}
