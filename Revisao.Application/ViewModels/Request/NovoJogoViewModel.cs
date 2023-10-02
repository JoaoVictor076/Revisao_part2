﻿using System.ComponentModel.DataAnnotations;

namespace Revisao.Application.ViewModels.Request
{
    public class NovoJogoViewModel
    {
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