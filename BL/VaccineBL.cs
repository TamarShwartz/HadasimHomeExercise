using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Project.Models;

namespace BL
{
    public class VaccineBL:IVaccineBL
    {
        IVaccineDL vaccineDL;
        public VaccineBL(IVaccineDL vaccineDL)
        {
            this.vaccineDL = vaccineDL;
        }
        public async Task<Vaccine> Get(int id)
        {
            return await vaccineDL.Get(id);
        }
        public async Task Post( Vaccine newvaccine)
        {
            await vaccineDL.Post(newvaccine);
        }
    }
}
