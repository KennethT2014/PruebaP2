using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarProveedoresBinary
{
    [Serializable]
    public class RegistroSerializable
    {
        private string id;
        private string proveedor;
        private string telefono;
        private string direccion;

        public RegistroSerializable() : this ("", "", "", "") { }

        public RegistroSerializable(string valorId, string valorProveedor, string valorTelefono, string valorDireccion)
        {
            Id = valorId;
            Proveedor = valorProveedor;
            Telefono = valorTelefono;
            Direccion = valorDireccion;
        }

        public string Id { get { return id; } set {  id = value; } }
        public string Proveedor { get { return proveedor; } set { proveedor = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
    }
}
