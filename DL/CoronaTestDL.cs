using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class CoronaTestDL:ICoronaTestDL
    {
        public CoronaStockContext context;
        public CoronaTestDL(CoronaStockContext context)
        {
            this.context = context;
        }

        public async Task<List<CoronaTest>> Get(int id)
        {
         return await context.CoronaTests.Where(c => c.CustomerId == id).ToListAsync();
        }

        public async Task Post(CoronaTest coronaTest)
        {
            await context.CoronaTests.AddAsync(coronaTest);
            await context.SaveChangesAsync();
        }
    }
}
