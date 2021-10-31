using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models
{
    public class PersonAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonAddressId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public long PersonId { get; set; }
        public Person Person { get; set; }
    }
}