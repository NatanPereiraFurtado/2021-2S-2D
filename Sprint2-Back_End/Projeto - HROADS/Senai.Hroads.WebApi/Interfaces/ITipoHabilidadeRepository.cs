using Sprint2___Projeto_HROADS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> Listar();
        TipoHabilidade BuscarPorId(int idTipoHabilidade);
        void Cadastrar(TipoHabilidade novoTipoHabilidade);
        void Atualizar(int idTipoHabilidade, TipoHabilidade TipoHabilidadeAtualizada);
        void Deletar(int idTipoHabilidade);
    }
}
