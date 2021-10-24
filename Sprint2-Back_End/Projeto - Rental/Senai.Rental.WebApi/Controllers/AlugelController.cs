using Microsoft.AspNetCore.Mvc;
using Sprint2___Projeto_Rental.Domain;
using Sprint2___Projeto_Rental.Interfaces;
using Sprint2___Projeto_Rental.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Rental.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AluguelController : ControllerBase
    {
        private IAluguelRepository _aluguelRepository { get; set; }
        public AluguelController()
        {
            _aluguelRepository = new AluguelRepository();
        }

        [HttpGet("ListaAluguel")]
        public IActionResult Get()
        {
            List<AluguelDomain> listaAlugueis = _aluguelRepository.ListarTodos();
            return Ok(listaAlugueis);
        }
        [HttpGet("Busca/{id}")]
        public IActionResult GetById(int id)
        {
            AluguelDomain aluguelBusca = _aluguelRepository.BuscarPorId(id);

            if (aluguelBusca == null)
            {
                return NotFound("Nenhum aluguel foi encontrado!");
            }

            return Ok(aluguelBusca);
        }
        [HttpPost("CadastroAluguel")]
        public IActionResult Post(AluguelDomain novoAluguel)
        {
            _aluguelRepository.Cadastrar(novoAluguel);
            return Ok(novoAluguel);
        }
        [HttpPut("Atualiza/{id}")]
        public IActionResult PutIdUrl(int id, AluguelDomain aluguelAtt)
        {
            AluguelDomain aluguelBuscado = _aluguelRepository.BuscarPorId(id);

            if (aluguelBuscado == null)
            {
                return NotFound(
                        new
                        {
                            mensagem = "Aluguel não encontrado!",
                            erro = true
                        }
                    );
            }

            try
            {
                _aluguelRepository.AtualizaridUrl(id, aluguelAtt);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPut("AtualizaCorpo")]
        public IActionResult PutIdBody(AluguelDomain aluguelAtt)
        {
            if (aluguelAtt.idVeiculos <= 0 || aluguelAtt.idAluguel <= 0)
            {
                return BadRequest(
                    new
                    {
                        mensagemErro = "os ids do Veiculo e do Aluguel não foram informados!"
                    });
            }

            AluguelDomain aluguelBuscado = _aluguelRepository.BuscarPorId(aluguelAtt.idAluguel);

            if (aluguelBuscado != null)
            {
                try
                {
                    _aluguelRepository.AtualizaridCorpo(aluguelAtt);

                    return NoContent();
                }
                catch (Exception codErro)
                {
                    return BadRequest(codErro);
                }
            }

            return NotFound(
                    new
                    {
                        mensagem = "Aluguel não encontrado!",
                        errorStatus = true
                    }
                );
        }
        [HttpDelete("Deletar/{id}")]
        public IActionResult Delete(int id)
        {
            _aluguelRepository.Deletar(id);
            return NoContent();
        }
    }
}
