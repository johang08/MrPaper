using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MrPaper.Entidades
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        public string Suplidor { get; set; }
        public virtual List<ProductosDetalle> Productos { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Total { get; set; }

        public Compras()
        {
            CompraId = 0;
            Suplidor = string.Empty;
            Productos = new List<ProductosDetalle>();
            FechaCompra = DateTime.Now;
            Total = 0;
        }
    }
}
