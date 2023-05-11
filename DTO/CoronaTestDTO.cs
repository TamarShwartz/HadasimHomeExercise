using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CoronaTestDTO
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }

        public DateTime? TestDate { get; set; }
        public bool? TestAnswer { get; set; }
    }
}
