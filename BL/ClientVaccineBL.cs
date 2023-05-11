using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace BL
{
    public class ClientVaccineBL:IClientVaccineBL
    {
        IClientVaccineDL clientVaccineDL;
        public ClientVaccineBL(IClientVaccineDL clientVaccineDL)
        {
            this.clientVaccineDL = clientVaccineDL;
        }
        public async Task<List<ClientVaccine>> Get(int Id)
        {
            return await clientVaccineDL.Get(Id);
        }
        public async Task<string> Post(ClientVaccine value)
        {
            List<ClientVaccine> res = await clientVaccineDL.Get(value.CustomerId.Value);
            if (res.Count >= 4)
                return "You cannot get the vaccine";
            else
                return await clientVaccineDL.Post(value);
        }
    }
}
