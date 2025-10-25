using System.Collections.Generic;

namespace GestionInventariosElectronicos.Modelos
{
    public class Categoria
    {
        private readonly List<Producto> G5_productos = new List<Producto>();

        public Categoria(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; }

        public void AgregarProducto(Producto G5_producto)
        {
            G5_productos.Add(G5_producto);
        }

        public int CalcularStockTotal()
        {
            return G5_CalcularStockRecursivo(G5_productos, 0);
        }

        private int G5_CalcularStockRecursivo(IReadOnlyList<Producto> G5_lista, int G5_indice)
        {
            if (G5_indice >= G5_lista.Count)
            {
                return 0;
            }

            Producto G5_productoActual = G5_lista[G5_indice];
            return G5_productoActual.Cantidad + G5_CalcularStockRecursivo(G5_lista, G5_indice + 1);
        }
    }
}
