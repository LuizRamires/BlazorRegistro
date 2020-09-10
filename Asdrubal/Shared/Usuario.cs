using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Asdrubal.Shared
{
    public class Usuario
    {
        [Required]
        public string titulo { get; set;}

        [Required]
        public string nome { get; set; }

        [Required]
        public string sobrenome { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public bool check { get; set; }
        
        [Required]
        [MinLength(6, ErrorMessage = "Senha muito pequena (mínimo 6 caractéres).")]
        public string senha { get; set; }

        [Required]
        public DateTime data { get; set; }

    }
}
