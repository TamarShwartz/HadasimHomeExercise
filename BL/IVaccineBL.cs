using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IVaccineBL
    {
        Task<Vaccine> Get(int id);
        Task Post(Vaccine newvaccine);
    }
}
