using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface ICustomerDL
    {
        Task<Customer> Get(string FirstName, string LastName, string Id);
        Task<List<Customer>> Get();
        Task<Customer> Post(Customer newUser);
    }
}
