using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class VaccineDL:IVaccineDL
    {
        public CoronaStockContext context;


        public VaccineDL(CoronaStockContext context)
        {
            this.context = context;
        }

        public async Task<Vaccine> Get(int id)
        {
            return await context.Vaccines.Where(c =>  c.Id == id).FirstOrDefaultAsync();
        }
        public async Task Post(Vaccine newvaccine)
        {
            await context.Vaccines.AddAsync(newvaccine);
            await context.SaveChangesAsync();
        }
    }
}
