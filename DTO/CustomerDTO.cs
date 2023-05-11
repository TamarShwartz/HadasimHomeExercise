using System;

namespace DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string HouseNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }

    }
}
