using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Inlock.Domains
{
    public class UsuarioDomain
    {
        public int idUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public TipoUsuarioDomain idTipoUsuario { get; set; }
    }
}
