using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrPaper.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUser { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public object Nombres { get; internal set; }
        public object NombreUsuario { get; internal set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            NombreUser = string.Empty;
            Clave = string.Empty;
            ConfirmarClave = string.Empty;
            Fecha = DateTime.Now;
        }
    }
}
