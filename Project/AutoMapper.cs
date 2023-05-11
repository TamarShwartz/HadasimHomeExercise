
using AutoMapper;
using DTO;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project
{
    public class AutoMapper : Profile
    {
        public AutoMapper autoMapper;
        public AutoMapper()
        {

            CreateMap<Customer, CustomerDTO>(); 
            CreateMap<CustomerDTO, Customer>();
            CreateMap<ClientVaccinesDTO, ClientVaccine>();
            CreateMap<ClientVaccine, ClientVaccinesDTO > ();
            CreateMap<Vaccine, VaccineDTO> ();
            CreateMap<VaccineDTO, Vaccine> ();
            CreateMap<CoronaTest, CoronaTestDTO> ();
            CreateMap<CoronaTestDTO, CoronaTest> ();

         }
    }
}

