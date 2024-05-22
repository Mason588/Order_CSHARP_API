using System.ComponentModel.DataAnnotations;

namespace Order
{
    public class Order
    {
        [Required]
        public string CustomerId { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Order must contain at least one item.")]
        public List<Item> Items { get; set; }

        [Required]
        [Range(0.0, double.MaxValue, ErrorMessage = "Total amount must be non-negative.")]
        public double TotalAmount { get; set; }
    }

}
