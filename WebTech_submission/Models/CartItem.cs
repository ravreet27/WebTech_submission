using System.ComponentModel.DataAnnotations;

namespace WebTech_submission.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
