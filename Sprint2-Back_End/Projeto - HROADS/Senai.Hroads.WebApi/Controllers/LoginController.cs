using Microsoft.AspNetCore.Mvc;
using Sprint2___Projeto_HROADS.Domains;
using Sprint2___Projeto_HROADS.Interfaces;
using Sprint2___Projeto_HROADS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(Usuario Login)
        {
            Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailSenha(Login.Email, Login.Senha);

            if (usuarioBuscado == null)
                return NotFound("E-mail ou senha inválidos!");


        }


    }
}
