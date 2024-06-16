using LogisticaHogar.Backend.Model;

namespace LogisticaHogar.Backend.Services.Services
{
    public class ProductoService : IProductoService
    {
        private readonly List<Producto> _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Producto 1", Tipo = "Tipo 1", Cantidad = 10.0, Unidad = "kg", EsPropio = true },
            new Producto { Id = 2, Nombre = "Producto 2", Tipo = "Tipo 2", Cantidad = 5.0, Unidad = "ltr", EsPropio = false }
        };

        public IEnumerable<Producto> GetProductos() => _productos;

        public Producto GetProductoById(int id) => _productos.FirstOrDefault(p => p.Id == id);

        public void AddProducto(Producto producto)
        {
            producto.Id = _productos.Max(p => p.Id) + 1;
            _productos.Add(producto);
        }

        public void UpdateProducto(Producto producto)
        {
            var existingProducto = _productos.FirstOrDefault(p => p.Id == producto.Id);
            if (existingProducto != null)
            {
                existingProducto.Nombre = producto.Nombre;
                existingProducto.Tipo = producto.Tipo;
                existingProducto.Cantidad = producto.Cantidad;
                existingProducto.Unidad = producto.Unidad;
                existingProducto.EsPropio = producto.EsPropio;
            }
        }

        public void DeleteProducto(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
        }
    }
}
