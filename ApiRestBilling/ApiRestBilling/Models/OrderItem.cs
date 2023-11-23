using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiRestBilling.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal Unitprice { get; set; } = 0;
        public object UnitPrice { get; internal set; }
        [Required]
        public int Quantity { get; set; } = 1;
        [ForeignKey("OrderId")]
        public  Order order  { get; set; }
        [ForeignKey("ProductId")]
        public  Product product { get; set; }
        public object Subtotal { get; internal set; }
    }
}
