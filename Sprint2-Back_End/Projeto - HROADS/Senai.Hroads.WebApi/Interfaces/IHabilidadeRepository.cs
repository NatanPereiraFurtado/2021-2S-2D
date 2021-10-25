using Sprint2___Projeto_HROADS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Interfaces
{
    interface IHabilidadeRepository
    {
        interface IHabilidadeRepository
        {
            List<Habilidade> Listar();
            List<Habilidade> ListarAll();
            Habilidade BuscarPorId(int idHabilidade);
            void Cadastrar(Habilidade novHabilidade);
            void Atualizar(int idHabilidade, Habilidade HabilidadeAtualizada);
            void Deletar(int idHabilidade);
        }
    }
}
