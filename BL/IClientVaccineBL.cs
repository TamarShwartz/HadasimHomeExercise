using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IClientVaccineBL
    {
        Task<List<ClientVaccine>> Get(int Id);
        Task<string> Post(ClientVaccine value);
    }
}
