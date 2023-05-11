using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DL;
using Microsoft.Extensions.Configuration;
using Project.Models;

namespace BL
{
    public class CustomerBL : ICustomerBL
    {

        ICustomerDL customerDL;
        IConfiguration _configuration;
        public CustomerBL(ICustomerDL customerDL, IConfiguration configuration)
        {
            this.customerDL = customerDL;
            _configuration = configuration;
        }
        public async Task<Customer> Get(string FirstName, string LastName, string Id)
        {
            return await customerDL.Get(FirstName, LastName, Id);
        }
        public async Task<List<Customer>> Get()
        {
            return await customerDL.Get();
        }
        public async Task<Customer> Post(Customer newUser)
        {
            var user = await customerDL.Post(newUser);
            if (user == null)
                return null;
            return user;

        }
    }
}
