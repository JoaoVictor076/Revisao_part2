using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class JogoMegaSena
    {
        public JogoMegaSena(string nome, string cpf, int primeiro_numero, int segundo_numero, int terceiro_numero, int quarto_numero, int quinto_numero, int sexto_numero, DateTime dataDoJogo)
        {
            Nome = nome;
            Cpf = cpf;
            this.primeiro_numero = primeiro_numero;
            this.segundo_numero = segundo_numero;
            this.terceiro_numero = terceiro_numero;
            this.quarto_numero = quarto_numero;
            this.quinto_numero = quinto_numero;
            this.sexto_numero = sexto_numero;
            DataDoJogo = dataDoJogo;
        }

        [MinLength(3, ErrorMessage = "Minimo de 3 letras.")]
        [MaxLength(255, ErrorMessage = "maximo ....")]
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int primeiro_numero { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int segundo_numero { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int terceiro_numero { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int quarto_numero { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int quinto_numero { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int sexto_numero { get; set; }
        public DateTime DataDoJogo { get; set; }
    }
}
