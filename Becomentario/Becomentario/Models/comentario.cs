using System.ComponentModel.DataAnnotations;

namespace Becomentario.Models
{
    public class comentario
    {
        public int id { get; set; }
        [Required]
        public string titulo { get; set; }
        [Required]
        public string creador { get; set; }
        [Required]
        public string texto { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        public double precio { get; set; }
    }
}
