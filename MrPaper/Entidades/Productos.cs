using System.ComponentModel.DataAnnotations;

namespace MrPaper.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string NombreProduct { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }
        public int Inventario { get; set; }
        public string Descripcion { get; set; }

        public Productos()
        {
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
