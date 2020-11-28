using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consulta_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var sueldo = Convert.ToInt32(textBox1.Text);
            using (ServiceEmpleado.Service1Client empleado = new ServiceEmpleado.Service1Client())
            {
                var emp = empleado.ObtenerEmpleado(sueldo);
                var id = emp.Id_Empleado;
                var nom = emp.Nombre;
                var em = emp.Email;
                var ed = emp.Edad;
                var tel = emp.Telefono;
                var dir = emp.Direccion;

                textBox2.Text = Convert.ToInt32(emp.Id_Empleado).ToString();
                textBox3.Text = emp.Nombre;
                textBox4.Text = emp.Email;
                textBox5.Text = Convert.ToInt32(emp.Edad).ToString();
                textBox6.Text = emp.Telefono;
                textBox7.Text = emp.Direccion;
            }
        }
    }
}
