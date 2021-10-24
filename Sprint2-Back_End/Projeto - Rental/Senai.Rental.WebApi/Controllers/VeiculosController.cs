using Microsoft.AspNetCore.Mvc;
using Senai.Rental.WebApi.Domains;
using Sprint2___Projeto_Rental.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Rental.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private IVeiculosRepository _veiculoRepository { get; set; }
        public VeiculosController()
        {
            _veiculoRepository = new VeiculosRepository();
        }

        [HttpGet("ListaVeiculos")]
        public IActionResult Get()
        {
            List<VeiculosDomain> listaVeiculos = _veiculoRepository.ListarTodos();
            return Ok(listaVeiculos);
        }
        [HttpGet("Busca/{id}")]
        public IActionResult GetById(int id)
        {
            VeiculosDomain VeiculoBusca = _veiculoRepository.BuscarPorId(id);

            if (VeiculoBusca == null)
            {
                return NotFound("Nenhum Veiculo foi encontrado!");
            }

            return Ok(VeiculoBusca);
        }
        [HttpPost("CadastroVeiculos")]
        public IActionResult Post(VeiculosDomain novoVeiculo)
        {
            _veiculoRepository.Cadastrar(novoVeiculo);
            return Ok(novoVeiculo);
        }
        [HttpPut("Atualiza/{id}")]
        public IActionResult PutIdUrl(int id, VeiculosDomain veiculoAtt)
        {
            VeiculosDomain veiculoBuscado = _veiculoRepository.BuscarPorId(id);

            if (veiculoBuscado == null)
            {
                return NotFound(
                        new
                        {
                            mensagem = "Veiculos não encontrado!",
                            erro = true
                        }
                    );
            }

            try
            {
                _veiculoRepository.AtualizaridUrl(id, veiculoAtt);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPut("AtualizaCorpo")]
        public IActionResult PutIdBody(VeiculosDomain veiculoAtt)
        {
            if (veiculoAtt.idModelo <= 0 || veiculoAtt.Placa == null)
            {
                return BadRequest(
                    new
                    {
                        mensagemErro = "o id do Modelo e Placa não foram informados!"
                    });
            }

            VeiculosDomain veiculoBuscado = _veiculoRepository.BuscarPorId(veiculoAtt.idVeiculos);

            if (veiculoBuscado != null)
            {
                try
                {
                    _veiculoRepository.AtualizaridCorpo(veiculoAtt);

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
                        mensagem = "Veiculo não encontrado!",
                        errorStatus = true
                    }
                );
        }
        [HttpDelete("Deletar/{id}")]
        public IActionResult Delete(int id)
        {
            _veiculoRepository.Deletar(id);
            return NoContent();
        }
    }
}