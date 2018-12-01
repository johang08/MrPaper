
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MrPaper.Entidades
{
    public class ProductosDetalle
    {
        [Key]
        public int ProductosDetalleId { get; set; }
        public int ProductoId { get; set; }
        public string NombreProduct { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }
        public int Inventario { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Productos Producto { get; set; }

        public ProductosDetalle(int productosDetalleId, int productoId, string nombreProduct, decimal costo, decimal precio, decimal ganancia, int inventario, string descripcion)
        {
            ProductosDetalleId = productosDetalleId;
            ProductoId = productoId;
            NombreProduct = nombreProduct;
            Costo = costo;
            Precio = precio;
            Ganancia = ganancia;
            Inventario = inventario;
            Descripcion = descripcion;
        }

        public ProductosDetalle()
        {
            ProductosDetalleId = 0;
            ProductoId = 0;
            NombreProduct = string.Empty;
            Costo = 0;
            Precio = 0;
            Ganancia = 0;
            Inventario = 0;
            Descripcion = string.Empty;
        }
    }
}
