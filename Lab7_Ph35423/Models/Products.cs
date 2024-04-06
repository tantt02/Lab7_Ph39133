using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Xml.Linq;

namespace Bai1.Models
{

    public class Products
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }
        public string Color { get; set; }
        public int UnitPrice { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime CratedDate { get; set; }
    }
}
