using Sprint2___Projeto_HROADS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Interfaces
{
    interface IClasseRepository
    {
        interface IClasseRepository
        {
            IClasseHabilidadeRepository BuscarPorId(int idClasse);

            List<Classe> Listar();
            List<Classe> ListarAll();
            void Cadastrar(Classe novaClasse);
            void Atualizar(int idClasse, Classe classeAtualizada);
            void Deletar(int idClasse);
        }
    }
}
