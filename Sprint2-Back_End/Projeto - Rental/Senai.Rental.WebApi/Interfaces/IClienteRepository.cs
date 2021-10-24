using Senai.Rental.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Rental.Interfaces
{
    interface IClienteRepository
    {
        List<ClienteDomain> ListarTodos();
        ClienteDomain BuscarPorId(int id);
        void Cadastrar(ClienteDomain novoCliente);
        void AtualizaridCorpo(ClienteDomain clienteAtt);
        void AtualizaridUrl(int idCliente, ClienteDomain clienteAtt);
        void Deletar(int idCliente);

    }
}