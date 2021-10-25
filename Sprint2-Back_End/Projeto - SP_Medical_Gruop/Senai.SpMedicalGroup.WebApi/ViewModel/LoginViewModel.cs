using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Por favor, informe o e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha")]
        [StringLength(256, MinimumLength = 8, ErrorMessage = "O campo senha precisa ter no mínimo 8 caracteres")]
        public string Senha { get; set; }
    }
}
