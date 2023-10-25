using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoJuego.Models
{
    public class Email
    {
        [Key]
        public int idEmail { get; set; }
        public string E_mail { get; set; }
        public int idUsuario { get; set; }
        
    }
}
