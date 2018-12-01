using System;
using System.ComponentModel.DataAnnotations;


namespace MrPaper.Entidades
{
    public class Suplidores
    {
        internal DateTime Fecha;

        [Key]
        public int SuplidorID { get; set; }
        public string NombreEmpresa { get; set; }
        public int RNC { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Suplidores()
        {
            SuplidorID = 0;
            NombreEmpresa = string.Empty;
            RNC = 0;
            Direccion = string.Empty;
            Telefono = String.Empty;
        }
    }
}
