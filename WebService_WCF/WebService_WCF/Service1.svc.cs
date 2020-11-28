using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;

namespace WebService_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        //Metodo para consultar el registro de empleados
        public Empleado ObtenerEmpleado(double Sueldo)
        {
            if (Sueldo == 100.00) 
            {
                return new Empleado() { Id_Empleado = 001, Nombre = "Diana", Email = "Diana@gmail.com", Edad = 21, Telefono = "8821866", Direccion = "C. Lucio Rosales"};
            }
            else if (Sueldo == 200.00)
            {
                return new Empleado() { Id_Empleado = 002, Nombre = "Andrea", Email = "Andrea@gmail.com", Edad = 20, Telefono = "8821579", Direccion = "Av. Morelos"};
            }
            else if (Sueldo == 300.00)
            {
                return new Empleado() { Id_Empleado = 003, Nombre = "Alan", Email = "Alan@gmail.com", Edad = 20, Telefono = "8879612", Direccion = "Av. Heroes de Chapultepec" };
            }
            else
            {
                return new Empleado(){ Error = "El empleado con ese sueldo no se encontro en la base de datos" };
            }
        }

        //Metodo para consultar los productos
        public Productos ConsultarProducto(int precio)
        {
            if (precio == 10)
            {
                return new Productos() { Id_producto = 001, Nombre ="Pepsi", Caducidad ="10/12/2022", Existencia = 30, Id_proveedor = 0009};
            }
            else if (precio == 15)
            {
                return new Productos() { Id_producto = 002, Nombre = "Oreo", Caducidad = "05/08/2020", Existencia = 5, Id_proveedor = 0005};
            }
            else if (precio == 25)
            {
                return new Productos() { Id_producto = 003, Nombre = "Arroz", Caducidad = "12/03/2001", Existencia = 9, Id_proveedor = 0003 };
            }
            else
            {
                return new Productos() { Error = "No se encontro el producto en existencia" };
            }
        }

        //Metodo para consultar los proveedores
        public Proveedores BuscarProveedores(string Marca)
        {
            if (Marca == "Gamesa")
            {
                return new Proveedores() {Id_proveedor =001, Nombre ="Luis", Telefono=8824615, Direccion="Av. Jesus Agustin Castro"};
            }
            else if (Marca == "Barcel")
            {
                return new Proveedores() {Id_proveedor = 002, Nombre="Alonso", Telefono=8884165, Direccion="C. Felipe Carrillo Puerto"};
            }
            else if (Marca == "Danone")
            {
                return new Proveedores() { Id_proveedor = 003, Nombre = "Joel", Telefono = 8965712, Direccion = "C. Juan Limon" };
            }
            else
            {
                return new Proveedores() { Error = "No se encontro el proveedor de la marca" };
            }
        }
    }
}
