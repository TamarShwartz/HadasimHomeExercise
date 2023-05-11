using AutoMapper;
using BL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerBL CustomerBl;
        IMapper mapper;

        public CustomerController(ICustomerBL CustomerBl, IMapper imapper)
        {
            this.CustomerBl = CustomerBl;
            this.mapper = imapper;
        }


        [HttpGet("{FirstName}/{LastName}/{Id}")]
        public async Task<CustomerDTO> Get(string FirstName, string LastName, string Id)
        {
            Customer res = await CustomerBl.Get(FirstName, LastName, Id);
            CustomerDTO customerDTO = mapper.Map<Customer, CustomerDTO>(res);
            return customerDTO;

        }
        // GET api/<CustomerController>/5
        [HttpGet]
        public async Task<List<Customer>> Get()
        {
            return await CustomerBl.Get();

        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<Customer>> Post([FromBody] CustomerDTO newCustomer)
        {
            Customer res = mapper.Map<CustomerDTO, Customer>(newCustomer);
            return await CustomerBl.Post(res);
        }

    }
}
