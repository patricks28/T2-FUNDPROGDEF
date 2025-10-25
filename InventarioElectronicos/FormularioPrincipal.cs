using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionInventariosElectronicos.Modelos;

namespace GestionInventariosElectronicos
{
    public partial class FormularioPrincipal : Form
    {
        private readonly List<Producto> G5_listaProductos = new List<Producto>();

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void G5_botonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string G5_nombre = G5_cuadroNombre.Text.Trim();
                string G5_categoria = G5_cuadroCategoria.Text.Trim();
                string G5_precioTexto = G5_cuadroPrecio.Text.Trim();
                string G5_cantidadTexto = G5_cuadroCantidad.Text.Trim();

                if (string.IsNullOrWhiteSpace(G5_nombre) || string.IsNullOrWhiteSpace(G5_categoria) ||
                    string.IsNullOrWhiteSpace(G5_precioTexto) || string.IsNullOrWhiteSpace(G5_cantidadTexto))
                {
                    throw new ArgumentException("Todos los campos son obligatorios para registrar un producto.");
                }

                if (!decimal.TryParse(G5_precioTexto, out decimal G5_precio))
                {
                    throw new ArgumentException("El precio debe ser un número válido.");
                }

                if (!int.TryParse(G5_cantidadTexto, out int G5_cantidad) || G5_cantidad < 0)
                {
                    throw new ArgumentException("La cantidad debe ser un número entero mayor o igual a cero.");
                }

                bool G5_yaExiste = G5_listaProductos.Any(G5_producto =>
                    G5_producto.Nombre.Equals(G5_nombre, StringComparison.OrdinalIgnoreCase));

                if (G5_yaExiste)
                {
                    throw new InvalidOperationException("Ya existe un producto con el mismo nombre.");
                }

                Producto G5_nuevoProducto = new Producto(G5_nombre, G5_categoria, G5_precio, G5_cantidad);
                G5_listaProductos.Add(G5_nuevoProducto);
                G5_ActualizarListaProductos(G5_listaProductos);
                G5_LimpiarCampos();
                MessageBox.Show("Producto registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception G5_excepcion)
            {
                MessageBox.Show(G5_excepcion.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G5_botonBuscar_Click(object sender, EventArgs e)
        {
            string G5_nombreBusqueda = G5_cuadroNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(G5_nombreBusqueda))
            {
                MessageBox.Show("Ingrese el nombre del producto a buscar.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto G5_productoEncontrado = G5_listaProductos.FirstOrDefault(G5_producto =>
                G5_producto.Nombre.Equals(G5_nombreBusqueda, StringComparison.OrdinalIgnoreCase));

            if (G5_productoEncontrado == null)
            {
                MessageBox.Show("No se encontró un producto con ese nombre.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            G5_ActualizarListaProductos(new List<Producto> { G5_productoEncontrado });
        }

        private void G5_botonOrdenAsc_Click(object sender, EventArgs e)
        {
            List<Producto> G5_ordenados = G5_listaProductos
                .OrderBy(G5_producto => G5_producto.Precio)
                .ToList();
            G5_ActualizarListaProductos(G5_ordenados);
        }

        private void G5_botonOrdenDesc_Click(object sender, EventArgs e)
        {
            List<Producto> G5_ordenados = G5_listaProductos
                .OrderByDescending(G5_producto => G5_producto.Precio)
                .ToList();
            G5_ActualizarListaProductos(G5_ordenados);
        }

        private void G5_botonCalcularStock_Click(object sender, EventArgs e)
        {
            Dictionary<string, Categoria> G5_categorias = G5_CrearCategoriasDesdeProductos();
            if (G5_categorias.Count == 0)
            {
                MessageBox.Show("No hay productos registrados para calcular el stock.", "Sin productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder G5_mensaje = new StringBuilder();
            foreach (Categoria G5_categoria in G5_categorias.Values)
            {
                int G5_stock = G5_categoria.CalcularStockTotal();
                G5_mensaje.AppendLine($"Categoría {G5_categoria.Nombre}: {G5_stock} unidades");
            }

            MessageBox.Show(G5_mensaje.ToString(), "Stock por categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Dictionary<string, Categoria> G5_CrearCategoriasDesdeProductos()
        {
            Dictionary<string, Categoria> G5_diccionario = new Dictionary<string, Categoria>(StringComparer.OrdinalIgnoreCase);

            foreach (Producto G5_producto in G5_listaProductos)
            {
                if (!G5_diccionario.TryGetValue(G5_producto.Categoria, out Categoria G5_categoria))
                {
                    G5_categoria = new Categoria(G5_producto.Categoria);
                    G5_diccionario[G5_producto.Categoria] = G5_categoria;
                }

                G5_categoria.AgregarProducto(G5_producto);
            }

            return G5_diccionario;
        }

        private void G5_ActualizarListaProductos(IEnumerable<Producto> G5_productos)
        {
            G5_vistaProductos.Items.Clear();
            foreach (Producto G5_producto in G5_productos)
            {
                ListViewItem G5_item = new ListViewItem(new[]
                {
                    G5_producto.Nombre,
                    G5_producto.Categoria,
                    G5_producto.Precio.ToString("C"),
                    G5_producto.Cantidad.ToString()
                });

                G5_vistaProductos.Items.Add(G5_item);
            }
        }

        private void G5_LimpiarCampos()
        {
            G5_cuadroNombre.Clear();
            G5_cuadroCategoria.Clear();
            G5_cuadroPrecio.Clear();
            G5_cuadroCantidad.Clear();
        }

        private void G5_botonMostrarTodos_Click(object sender, EventArgs e)
        {
            G5_ActualizarListaProductos(G5_listaProductos);
        }
    }
}
