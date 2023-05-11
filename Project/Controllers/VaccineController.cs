using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Project.Models;
using DTO;
using AutoMapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        IVaccineBL vaccineBL;
        IMapper mapper;
        public VaccineController(IVaccineBL vaccineBL, IMapper imapper)
        {
            this.vaccineBL = vaccineBL;
            this.mapper = imapper;
        }

        // GET api/<VaccineController>/5
        [HttpGet("{id}")]
        public async Task<Vaccine> Get(int id)
        {
            return await vaccineBL.Get(id);
        }

        // POST api/<VaccineController>
        [HttpPost]
        public async Task Post([FromBody] VaccineDTO newvaccine)
        {
            Vaccine res = mapper.Map<VaccineDTO, Vaccine>(newvaccine);
            await vaccineBL.Post(res);
        }
    }
}
