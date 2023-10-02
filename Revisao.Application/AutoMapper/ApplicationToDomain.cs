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

    public class ApplicationToDomain : Profile
  {
        public ApplicationToDomain()
        {
            //Exemplo visto em sala de aula

            CreateMap<JogoMegaSenaViewModel, JogoMegaSena>()
               .ConstructUsing(q => new JogoMegaSena(q.Nome,q.Cpf, q.primeiro_numero, q.segundo_numero, q.terceiro_numero, q.quarto_numero, q.quinto_numero,q.sexto_numero,q.DataDoJogo)) ;

            CreateMap<NovoJogoViewModel, JogoMegaSena>()
               .ConstructUsing(q => new JogoMegaSena(q.Nome, q.Cpf, q.primeiro_numero, q.segundo_numero, q.terceiro_numero, q.quarto_numero, q.quinto_numero, q.sexto_numero, q.DataDoJogo));

        }
  }
          
}
