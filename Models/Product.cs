namespace Storage.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        public int Id { get; set; }
        
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
    }

