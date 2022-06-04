using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace restaurante.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        //public string Descripcion { get; set;}
        
        [Display (Name = "Categoria")]
        public int idCategoria { get; set; }
        [ForeignKey("idCategoria")]
        public Categoria? categoria { get; set; }

        //[Required]
        [Display (Name ="Imagen")]
        public string? rutaImagen { get; set; }
        [Required]
        public double precio { get; set; }

        
    }
}
    