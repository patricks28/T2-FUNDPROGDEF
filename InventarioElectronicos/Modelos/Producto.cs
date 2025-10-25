namespace GestionInventariosElectronicos.Modelos
{
    public class Producto
    {
        public Producto(string nombre, string categoria, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Cantidad = cantidad;
        }

        public string Nombre { get; }

        public string Categoria { get; }

        public decimal Precio { get; }

        public int Cantidad { get; }
    }
}
