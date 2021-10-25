using Sprint2___Projeto_Inlock.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Inlock.Interfaces
{
    interface IJogosRepository
    {
        List<JogosDomain> ListarTodos();
        JogosDomain BuscarPorId(int id);
        void Cadastrar(JogosDomain novoJogo);
        void AtualizarIdCorpo(JogosDomain jogoATT);
        void AtualizarIUrl(JogosDomain jogoATT);
        void Deletar(int id);
    }
}
