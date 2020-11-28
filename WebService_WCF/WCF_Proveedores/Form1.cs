using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF_Proveedores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var marca = textBox1.Text;
            using (ServiceProveedores.Service1Client proveedor = new ServiceProveedores.Service1Client())
            {
                var prov = proveedor.BuscarProveedores(marca);
                var id = prov.Id_proveedor;
                var nom = prov.Nombre;
                var tel = prov.Telefono;
                var dir = prov.Direccion;

                textBox2.Text = Convert.ToInt32(prov.Id_proveedor).ToString();
                textBox3.Text = prov.Nombre;
                textBox4.Text = Convert.ToInt32(prov.Telefono).ToString();
                textBox5.Text = prov.Direccion;
            }
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
