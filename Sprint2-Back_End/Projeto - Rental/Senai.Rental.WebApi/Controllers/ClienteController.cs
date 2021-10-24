using Microsoft.AspNetCore.Mvc;
using Sprint2___Projeto_Rental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Rental.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _clienteRepository { get; set; }
        public ClienteController()
        {
            _clienteRepository = new ClinteRepository();
        }

        [HttpGet("ListaCliente")]
        public IActionResult Get()
        {
            List<ClienteDomain> listaCliente = _clienteRepository.ListarTodos();
            return Ok(listaCliente);
        }

        [HttpGet("Busca/{id}")]
        public IActionResult GetById(int id)
        {
            ClienteDomain clienteBusca = _clienteRepository.BuscarPorId(id);

            if (clienteBusca == null)
            {
                return NotFound("Nenhum cliente foi encontrado!");
            }

            return Ok(clienteBusca);
        }
        [HttpPost("CadastroCliente")]
        public IActionResult Post(ClienteDomain novoCliente)
        {
            _clienteRepository.Cadastrar(novoCliente);
            return Ok(novoCliente);
        }
        [HttpPut("Atualiza/{id}")]
        public IActionResult PutIdUrl(int id, ClienteDomain clienteAtt)
        {
            ClienteDomain clienteBuscado = _clienteRepository.BuscarPorId(id);

            if (clienteBuscado == null)
            {
                return NotFound(
                        new
                        {
                            mensagem = "Cliente não encontrado!",
                            erro = true
                        }
                    );
            }

            try
            {
                _clienteRepository.AtualizaridUrl(id, clienteAtt);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
        [HttpPut("AtualizaCorpo")]
        public IActionResult PutIdBody(ClienteDomain clienteAtt)
        {
            if (clienteAtt.Nome == null || clienteAtt.Sobrenome == null || clienteAtt.CNH == null)
            {
                return BadRequest(
                    new
                    {
                        mensagemErro = "Nome, Sobrenome e CNH não foram informados!"
                    });
            }

            ClienteDomain ClienteBuscado = _clienteRepository.BuscarPorId(clienteAtt.idCliente);

            if (ClienteBuscado != null)
            {
                try
                {
                    _clienteRepository.AtualizaridCorpo(clienteAtt);

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
                        mensagem = "Cliente não encontrado!",
                        errorStatus = true
                    }
                );
        }
        [HttpDelete("Deletar/{id}")]
        public IActionResult Delete(int id)
        {
            _clienteRepository.Deletar(id);
            return NoContent();
        }
    }
}

