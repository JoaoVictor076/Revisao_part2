using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;

namespace Revisao.API.Controllers
{
    public class MegaSenaController : ControllerBase
    {
        private readonly IMegaSenaService _jogoService;

        public CartasController(ICartaService cartaService)
        {
            _cartaService = cartaService;
        }

        [HttpPost(Name = "AdicionarCartas")]
        public IActionResult Post(NovaCartaViewModel novaCartaViewModel)
        {
            _cartaService.AdicionarCartas(novaCartaViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodosAsCartas")]
        public IActionResult Get()
        {
            return Ok(_cartaService.ObterTodos());
        }


    }
}
