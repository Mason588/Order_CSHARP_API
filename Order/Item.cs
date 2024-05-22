using System.ComponentModel.DataAnnotations;

namespace Order
{
    public class Item
    {
        [Required]
        public string ProductId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public int Quantity { get; set; }
    }
}
