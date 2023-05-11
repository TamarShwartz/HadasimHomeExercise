using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using DTO;
using Project.Models;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientVaccineController : ControllerBase
    {
        IClientVaccineBL clientVaccineBL;
        IMapper mapper;


        public ClientVaccineController(IClientVaccineBL clientVaccineBL, IMapper imapper)
        {
            this.clientVaccineBL = clientVaccineBL;
            this.mapper = imapper;
        }
        // GET: api/<ClientVaccine>


        // GET api/<ClientVaccine>/5
        [HttpGet("{id}")]
        public async Task<List<ClientVaccine>> Get(int id)
        {
            return await clientVaccineBL.Get(id);
         //   ClientVaccinesDTO clientVaccineList = mapper.Map<ClientVaccine, ClientVaccinesDTO>(res);
          //  return clientVaccineList;
        }

        // POST api/<ClientVaccine>
        [HttpPost]
        public async Task<string> Post([FromBody] ClientVaccinesDTO value)
        {
            ClientVaccine clientVaccine = mapper.Map<ClientVaccinesDTO, ClientVaccine>(value);
            return await clientVaccineBL.Post(clientVaccine);

        }

    }
}
