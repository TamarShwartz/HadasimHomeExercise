using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class ClientVaccine
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? VaccineId { get; set; }
        public DateTime? DateReceived { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Vaccine Vaccine { get; set; }
    }
}
