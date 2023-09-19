using Entidades;

namespace WinFormCRUD
{
    public partial class FrmCRUD : Form
    {
        private List<Producto> productos;
        public FrmCRUD()
        {
            InitializeComponent();
            this.productos = new List<Producto>();
        }

        private void ActualizarVisor()
        {
            //limpiar visor
            this.lstVisor.Items.Clear();

            foreach (Producto p in this.productos)
            {
                //agrego lo que vale cada producto ya con el metodo Mostrar
                lstVisor.Items.Add(p.Mostrar());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmProducto frm1 = new FrmProducto();
            frm1.ShowDialog();

            if (frm1.DialogResult == DialogResult.OK)
            {
                this.productos.Add(frm1.producto);
                this.ActualizarVisor();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;

            if (indice == -1)
            {
                return;
            }

            Producto p = this.productos[indice];

            //generamos un objeto
            FrmProducto frm1 = new FrmProducto();
            //se muestra mi comentario
            frm1.ShowDialog();
            //que boton pulso
            if (frm1.DialogResult == DialogResult.OK)
            {
                //si fue presionado el aceptar ->
                this.productos[indice] = frm1.producto;
                //que se visualice en el listbox
                this.ActualizarVisor();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;

            if (indice == -1)
            {
                return;
            }

            Producto p = this.productos[indice];

            //generamos un objeto
            FrmProducto frm1 = new FrmProducto(p);
            //se muestra mi comentario
            frm1.ShowDialog();
            //que boton pulso
            if (frm1.DialogResult == DialogResult.OK)
            {
                //si fue presionado el aceptar ->
                this.productos.RemoveAt(indice);
                //que se visualice en el listbox
                this.ActualizarVisor();
            }
        }

        private void FrmCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}