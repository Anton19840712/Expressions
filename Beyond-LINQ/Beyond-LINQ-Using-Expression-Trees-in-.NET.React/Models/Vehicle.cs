using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long VehicleId { get; set; }
        public string Vin { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Fuel { get; set; }

        [ForeignKey("Person")]
        public long PersonId { get; set; }
        public Person CurrentPerson { get; set; }
    }
}
