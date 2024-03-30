using System.ComponentModel.DataAnnotations;

namespace WebTech_submission.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
