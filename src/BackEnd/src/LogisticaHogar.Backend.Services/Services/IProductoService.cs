using LogisticaHogar.Backend.Model;



namespace LogisticaHogar.Backend.Services.Services
{
    public interface IProductoService
    {
        IEnumerable<Producto> GetProductos();
        Producto GetProductoById(int id);
        void AddProducto(Producto producto);
        void UpdateProducto(Producto producto);
        void DeleteProducto(int id);
    }
}
