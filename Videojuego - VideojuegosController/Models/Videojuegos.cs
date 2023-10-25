using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoJuego.Models
{
    public class Estudiante
    {
        [Key]
        public int idVideojuego { get; set; }
        public string Nombre { get; set; }
        public string TipoDePago { get; set; }
        public bool EsGrupal { get; set; }
        public string Tipo { get; set; }
        public int idUsuario { get; set; }
    }
}