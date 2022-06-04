using System.ComponentModel.DataAnnotations;

namespace restaurante.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
