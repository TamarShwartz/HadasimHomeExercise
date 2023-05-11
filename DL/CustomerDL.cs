using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DL
{
    public class CustomerDL: ICustomerDL
    {
        public CoronaStockContext context;


        public CustomerDL(CoronaStockContext context)
        {
            this.context = context;
        }

        public async Task<Customer> Get(string FirstName, string LastName, string Id)
        {

            return await context.Customers.Where(c => c.FirstName == FirstName && c.LastName == LastName && c.Id.ToString() == Id).FirstOrDefaultAsync();
        }
        public async Task<List<Customer>> Get()
        {
            return await context.Customers.ToListAsync();
        }
        public async Task<Customer> Post(Customer newUser)
        {
            await context.Customers.AddAsync(newUser);
            await context.SaveChangesAsync();
            return newUser;
        }
    }
}
