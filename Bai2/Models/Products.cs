using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Bai2.Models
{
    public class Products
    {

        [Key]
        public Guid IdProduct { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Description { get; set; } = "";
        [Required]
        public string? Img { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int? Quantity { get; set; }
    
    }
}
