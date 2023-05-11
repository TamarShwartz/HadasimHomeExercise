using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class CoronaTest
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
       public int? VaccineId { get; set; }
        public DateTime? TestDate { get; set; }
        public bool? TestAnswer { get; set; }

        public virtual Customer Customer { get; set; }
      public virtual Vaccine Vaccine { get; set; }
    }
}
