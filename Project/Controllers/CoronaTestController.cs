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
    public class CoronaTestController : ControllerBase
    {
        ICoronaTestBL coronaTestBL;
        IMapper mapper;
        public CoronaTestController(ICoronaTestBL coronaTestBL, IMapper imapper)
        {
            this.coronaTestBL = coronaTestBL;
            this.mapper = imapper;
        }
        // GET api/<CoronaTestController>/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            var trueAnswer =await coronaTestBL.GetTtueAnswer(id);
            var recoveryDate = await coronaTestBL.GetRecoveryDate(id);
            return "The date of receiving a positive answer is" + trueAnswer+ "and the date of your recovery is " + recoveryDate;
        }

        // POST api/<CoronaTestController>
        [HttpPost]
        public async Task Post([FromBody] CoronaTestDTO value)
        {
            CoronaTest coronaTest = mapper.Map<CoronaTestDTO, CoronaTest>(value);
             await coronaTestBL.Post(coronaTest);
        }


    }
}
