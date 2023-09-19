using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCRUD
{
    public partial class FrmProducto : Form
    {

        public Entidades.Producto producto;

        public FrmProducto()
        {
            InitializeComponent();
        }

        public FrmProducto(Entidades.Producto producto) : this()
        {
            this.txtCodigo.Text = producto.codigo.ToString();
            this.txtNombre.Text = producto.nombre;
            this.txtPrecio.Text = producto.precio.ToString();
            this.txtCodigo.Enabled = false;
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {

        }


        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(this.txtCodigo.Text);
            string nombre = this.txtNombre.Text;
            double precio = double.Parse(this.txtPrecio.Text);

            this.producto = new Entidades.Producto(codigo, nombre, precio);

            this.DialogResult = DialogResult.OK;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
