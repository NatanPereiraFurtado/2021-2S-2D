using Microsoft.AspNetCore.Authorization;
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
    public class HabilidadeController : ControllerBase
    {

        private IHabilidadeRepository _HabilidadeRepository { get; set; }

        public HabilidadeController()
        {
            _HabilidadeRepository = new HabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_HabilidadeRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
                throw;
            }
        }

        [Authorize(Roles = "1")]
        [HttpGet("get/all")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_HabilidadeRepository.ListarAll());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
                throw;
            }
        }

        [HttpGet("{idHabilidade}")]
        public IActionResult GetById(int idHabilidade)
        {
            try
            {
                Habilidade HabilidadeBuscado = _HabilidadeRepository.BuscarPorId(idHabilidade);

                if (HabilidadeBuscado == null)
                {
                    return NotFound(
                            new
                            {
                                mensagem = "Habilidade não encontrada",
                                erro = true
                            }
                        );
                }
                return Ok(HabilidadeBuscado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Habilidade novaHabilidade)
        {
            try
            {
                _HabilidadeRepository.Cadastrar(novaHabilidade);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{idHabilidade}")]
        public IActionResult UpdateByUrl(int idHabilidade, Habilidade HabilidadeAtualizada)
        {
            try
            {
                _HabilidadeRepository.Atualizar(idHabilidade, HabilidadeAtualizada);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }

        }

        [Authorize(Roles = "1")]
        [HttpDelete("{idHabilidade}")]
        public IActionResult Delete(int idHabilidade)
        {
            try
            {
                _HabilidadeRepository.Deletar(idHabilidade);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

    }
}
