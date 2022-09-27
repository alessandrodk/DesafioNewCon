using AutoMapper;
using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper.Profiles
{
    public class PontoTuristicoProfile : Profile
    {
        public PontoTuristicoProfile()
        {
            CreateMap<PontoTuristicoDto, PontoTuristico>();
            CreateMap<PontoTuristico, PontoTuristicoDto>();

        }
    }
}
