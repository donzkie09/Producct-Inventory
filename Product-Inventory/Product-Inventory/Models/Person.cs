using System;
using System.Collections.Generic;

namespace Product_Inventory.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }        
        public string Nationality { get; set; }
    }
}
