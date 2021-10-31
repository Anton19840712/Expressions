using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models
{
    public class OrderProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderProductId { get; set; }

        [ForeignKey("Order")]
        public long OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Product")]
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}