namespace Entidades
{
    public class Producto
    {
        //atributos
        public int codigo;
        public string nombre;
        public double precio;

        //constructores
        public Producto(int codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        //metodos
        public string Mostrar()
        {
            return $"{this.codigo} - {this.nombre} - {this.precio}";
        }
    }
}