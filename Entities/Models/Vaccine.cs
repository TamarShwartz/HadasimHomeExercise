using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Vaccine
    {
        public Vaccine()
        {
            ClientVaccines = new HashSet<ClientVaccine>();
            CoronaTests = new HashSet<CoronaTest>();
        }

        public int Id { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string ManufacturerName { get; set; }

        public virtual ICollection<ClientVaccine> ClientVaccines { get; set; }
        public virtual ICollection<CoronaTest> CoronaTests { get; set; }
    }
}
