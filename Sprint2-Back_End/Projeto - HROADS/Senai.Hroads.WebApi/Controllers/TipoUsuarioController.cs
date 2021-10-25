using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sprint2___Projeto_HROADS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {

        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }


        public TiposUsuarioController()
        {
            _tipoUsuarioRepository = new TipousuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_tipoUsuarioRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpGet("{idTipoUsuario}")]
        public IActionResult GetById(int idTipoUsuario)
        {
            try
            {
                Tipousuario tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(idTipoUsuario);

                if (tipoUsuarioBuscado == null)
                {
                    return NotFound(
                            new
                            {
                                mensagem = "TipoUsuario não encontrado",
                                erro = true
                            }

                        ); ;

                }
                return Ok(tipoUsuarioBuscado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Tipousuario novoTipoUsuario)
        {
            try
            {
                _tipoUsuarioRepository.Cadastrar(novoTipoUsuario);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{idTipoUsuario}")]
        public IActionResult UpdateByUrl(int idTipoUsuario, Tipousuario tipoUsuarioAtualizado)
        {
            try
            {
                _tipoUsuarioRepository.Atualizar(idTipoUsuario, tipoUsuarioAtualizado);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{idTipoUsuario}")]
        public IActionResult Delete(int idTipoUsuario)
        {
            try
            {
                _tipoUsuarioRepository.Deletar(idTipoUsuario);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }

        }
    }
}
