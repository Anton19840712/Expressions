using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderId { get; set; }
        public DateTime Created { get; set; }
        public decimal OrderValue { get; set; }
        public bool IsShipped { get; set; }
        public IEnumerable<OrderProduct> OrderProducts { get; set; }
        [ForeignKey("Person")]
        public long PersonId { get; set; }
        public Person CurrentPerson { get; set; }
    }
}
