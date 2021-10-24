using Sprint2___Projeto_Rental.Domain;
using Sprint2___Projeto_Rental.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Rental.Repositories
{
    public class AluguelRepository : IAluguelRepository
    {
        private string stringConexao = "Data Source=DESKTOP-PVCFVR0\\SQLEXPRESS; initial catalog=T_Rental; user Id=sa; pwd=senai@132";
        public void AtualizaridCorpo(AluguelDomain aluguelAtt)
        {
            if (aluguelAtt.idVeiculos > 0)
            {

            }
        }

        public void AtualizaridCorpo(AluguelDomain aluguelAtt)
        {
            throw new NotImplementedException();
        }

        public void AtualizaridUrl(int idAluguel, AluguelDomain aluguelAtt)
        public void AtualizaridUrl(int idAluguel, AluguelDomain aluguelAtt)
        {
            throw new NotImplementedException();
        }

        public AluguelDomain BuscarPorId(int id)
        {

            if (rdr.Read())
            {
                AluguelDomain AluguelBusca = new AluguelDomain
                {

                };

                return AluguelBusca;
            }

            return null;
        }


        public void Cadastrar(AluguelDomain novoAluguel)
        {

        }





       public void Cadastrar(AluguelDomain novoAluguel)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idAluguel)
        {

        }
        public List<AluguelDomain> ListarTodos()
        {
            List<AluguelDomain> listaAluguel = new List<AluguelDomain>();
            {
                return listaAluguel;
            }

            AluguelDomain IAluguelRepository.BuscarPorId(int id);


            List<AluguelDomain> IAluguelRepository.ListarTodos();
            {
                throw new NotImplementedException();
            }


        }
    }
}