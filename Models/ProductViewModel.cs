using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class ProductViewModel
    {
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        [Display(Name = "Inventory Value")]
        [Range(0, 1000)]
        public int InventoryValue { get; set; }
        public int Id { get; internal set; }
    }
}
