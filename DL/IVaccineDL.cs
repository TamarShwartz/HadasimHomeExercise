using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface IVaccineDL
    {
        Task<Vaccine> Get(int id);
        Task Post(Vaccine newvaccine);
    }
}
