using Sprint2___Projeto_HROADS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Interfaces
{
    interface IClasseHabilidadeRepository
    {
        List<ClasseHabilidade> Listar();
        ClasseHabiliade BuscarPorId(int idClasseHabilidade);

        void Cadastrar(IClasseHabilidadeRepository novaClasseHabilidade);

        void Atualizar(int idClasseHabilidade, ClasseHabilidadeAtualizada);
        void Deletar(int idClasseHabilidae);
    }
}
