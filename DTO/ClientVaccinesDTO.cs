using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClientVaccinesDTO
    {
       public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? VaccineId { get; set; }
        public DateTime? DateReceived { get; set; }
    }
}
