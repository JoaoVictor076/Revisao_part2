using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels.Request;
using Revisao.Data.Repositories;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class MegaSenaService : IMegaSenaService 
    { 
    
    private readonly IMegaSenaRepository _jogoRepository;
    private IMapper _mapper;
    public MegaSenaService(IMegaSenaRepository jogoRepository, IMapper mapper)
    {
        _jogoRepository = jogoRepository;
        _mapper = mapper;
    }


    public void AdicionarJogos(NovoJogoViewModel novoJogoViewModel)
    {
        var novoJogo = _mapper.Map<JogoMegaSena>(novoJogoViewModel);
        _jogoRepository.RegistrarJogo(novoJogo);
    }



    public IEnumerable<JogoMegaSenaViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<JogoMegaSenaViewModel>>(_jogoRepository.ObterTodos());
    }

}
}
