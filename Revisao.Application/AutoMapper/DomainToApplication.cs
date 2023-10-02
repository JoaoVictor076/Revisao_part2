using AutoMapper;
using Revisao.Application.ViewModels.Request;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
    public  class DomainToApplication : Profile
    {
        public DomainToApplication()
        {

            CreateMap<JogoMegaSena, JogoMegaSenaViewModel>();
            CreateMap<JogoMegaSena, NovoJogoViewModel>();
        }
    }
}
