using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Producto_WCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var precios = Convert.ToInt32(textBox1.Text);
            using(ServiceProductos.Service1Client producto = new ServiceProductos.Service1Client())
            {
                var prod = producto.ConsultarProducto(precios);
                var id = prod.Id_producto;
                var nom = prod.Nombre;
                var cad = prod.Caducidad;
                var ex = prod.Existencia;
                var idprov = prod.Id_proveedor;

                textBox2.Text = Convert.ToInt32(prod.Id_producto).ToString();
                textBox3.Text = prod.Nombre;
                textBox4.Text = prod.Caducidad;
                textBox5.Text = Convert.ToInt32(prod.Existencia).ToString();
                textBox6.Text = Convert.ToInt32(prod.Id_proveedor).ToString();
            }
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
        }
    }
}
