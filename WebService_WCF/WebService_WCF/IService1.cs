using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Empleado ObtenerEmpleado(double Sueldo);
        [OperationContract]
        Productos ConsultarProducto(int Precio);
        [OperationContract]
        Proveedores BuscarProveedores(string Marca);

        // TODO: agregue aquí sus operaciones de servicio
    }

    //campos de datos de empleados

    [DataContract]
    public class Empleado:Mensaje
    {
        [DataMember]
        public int Id_Empleado { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int Edad { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        
    }

    //Mensaje en caso de error

    [DataContract]
    public class Mensaje
    {
        [DataMember]
        public string Respuesta { get; set; }
        [DataMember]
        public string Error { get; set; }
    }

    //campos de datos de productos
    [DataContract]
    public class Productos : Mensaje
    {
        [DataMember]
        public int Id_producto { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Caducidad { get; set; }
        [DataMember]
        public int Existencia { get; set; }
        [DataMember]
        public int Id_proveedor { get; set; }

    }

    //campos de datos de los proveedores

    [DataContract]
    public class Proveedores : Mensaje
    {
        [DataMember]
         public int Id_proveedor { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Telefono { get; set; }
        [DataMember]
        public string Direccion { get; set; }
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
