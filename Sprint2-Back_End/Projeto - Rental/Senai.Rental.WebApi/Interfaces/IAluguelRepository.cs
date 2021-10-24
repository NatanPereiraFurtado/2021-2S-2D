using Senai.Rental.WebApi.Domains;
using Sprint2___Projeto_Rental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Rental.Interfaces
{
    interface IAluguelRepository
    {
        List<AluguelDomain> ListarTodos();
        AluguelDomain BuscarPorId(int id);
        void Cadastrar(AluguelDomain novoAluguel);
        void AtualizaridCorpo(AluguelDomain aluguelAtt);
        void AtualizaridUrl(int idAluguel, AluguelDomain aluguelAtt);
        void Deletar(int idAluguel);
    }
}