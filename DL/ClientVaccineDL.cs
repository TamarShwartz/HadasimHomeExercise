using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace DL
{
    public class ClientVaccineDL: IClientVaccineDL
    {
        public CoronaStockContext context;
        public ClientVaccineDL(CoronaStockContext context)
        {
            this.context = context;
        }
        public async Task<List<ClientVaccine>> Get(int Id)
        {

            return await context.ClientVaccines.Where(c => c.CustomerId == Id).ToListAsync();
        }
        public async Task<string> Post(ClientVaccine value)
        {
            await context.ClientVaccines.AddAsync(value);
            await context.SaveChangesAsync();
            return "The vaccine was successfully received";

        }

    }
}
