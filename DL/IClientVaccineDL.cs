using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface IClientVaccineDL
    {
        Task<List<ClientVaccine>> Get(int value);
        Task<string> Post(ClientVaccine value);
    }
}
