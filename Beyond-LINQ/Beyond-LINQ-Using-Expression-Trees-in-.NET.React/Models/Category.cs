using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Force.Ddd;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public static readonly Spec<Category> NiceRating
            = new Spec<Category>(x => x.Rating > 50);
   
        public int Rating { get; set; }
    }
}