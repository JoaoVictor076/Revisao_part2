using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Revisao.Application.Interfaces;
using Revisao.Application.Services;
using Revisao.Application.ViewModels.Request;
using Revisao.Domain.Entities;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : Controller
    {
        private readonly IMegaSenaService _jogoService;

        public MegaSenaController(IMegaSenaService jogoService)
        {
            _jogoService = jogoService;
        }

        [HttpPost(Name = "AdicionarJogos")]
        public IActionResult Post(NovoJogoViewModel novoJogoViewModel)
        {
            if (novoJogoViewModel.primeiro_numero != novoJogoViewModel.segundo_numero && novoJogoViewModel.primeiro_numero != novoJogoViewModel.terceiro_numero
            && novoJogoViewModel.primeiro_numero != novoJogoViewModel.quarto_numero && novoJogoViewModel.primeiro_numero != novoJogoViewModel.quinto_numero
            && novoJogoViewModel.primeiro_numero != novoJogoViewModel.sexto_numero

            && novoJogoViewModel.segundo_numero != novoJogoViewModel.terceiro_numero && novoJogoViewModel.segundo_numero != novoJogoViewModel.quarto_numero
            && novoJogoViewModel.segundo_numero != novoJogoViewModel.quinto_numero && novoJogoViewModel.segundo_numero != novoJogoViewModel.sexto_numero

            && novoJogoViewModel.terceiro_numero != novoJogoViewModel.quarto_numero && novoJogoViewModel.terceiro_numero != novoJogoViewModel.quinto_numero
            && novoJogoViewModel.terceiro_numero != novoJogoViewModel.sexto_numero

            && novoJogoViewModel.quarto_numero != novoJogoViewModel.quinto_numero && novoJogoViewModel.terceiro_numero != novoJogoViewModel.sexto_numero

            && novoJogoViewModel.quinto_numero != novoJogoViewModel.sexto_numero)
            {
                _jogoService.AdicionarJogos(novoJogoViewModel);
                return Ok("Jogo Registrado com sucesso!");
            }
            else
            {
                return BadRequest("Dados incorretos, existem números repetidos no jogo");
            }
        }


        [HttpGet(Name = "ObterTodosOsJogos")]
        public IEnumerable<JogoMegaSenaViewModel> ObterNumeros()
        {
            string json = System.IO.File.ReadAllText(@"FileJsonData//jogosMega.json");
            IEnumerable<JogoMegaSenaViewModel> pegarNumeros = JsonConvert.DeserializeObject<IEnumerable<JogoMegaSenaViewModel>>(json);
            return pegarNumeros;
        }
    }
}





