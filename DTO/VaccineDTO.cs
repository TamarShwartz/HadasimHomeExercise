using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccineDTO
    {
        public int Id { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string ManufacturerName { get; set; }
    }
}
