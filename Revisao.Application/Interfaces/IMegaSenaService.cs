using Revisao.Application.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IMegaSenaService
    {

        IEnumerable<JogoMegaSenaViewModel> ObterTodos();
        void AdicionarJogos(NovoJogoViewModel jogo);
    }
}
