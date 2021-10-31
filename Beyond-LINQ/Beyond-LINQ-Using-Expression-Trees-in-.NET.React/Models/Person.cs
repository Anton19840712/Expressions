using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beyond_LINQ_Using_Expression_Trees_in_.NET.React.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid CartId { get; set; }
        public string JobTitle { get; set; }
        public int PersonAge { get; set; }
        public decimal EstimatedIncome { get; set; }

        public PersonAddress Address { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
