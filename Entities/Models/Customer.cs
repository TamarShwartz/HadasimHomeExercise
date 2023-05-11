using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Customer
    {
        public Customer()
        {
            ClientVaccines = new HashSet<ClientVaccine>();
            CoronaTests = new HashSet<CoronaTest>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string HouseNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

        public virtual ICollection<ClientVaccine> ClientVaccines { get; set; }
        public virtual ICollection<CoronaTest> CoronaTests { get; set; }
    }
}
