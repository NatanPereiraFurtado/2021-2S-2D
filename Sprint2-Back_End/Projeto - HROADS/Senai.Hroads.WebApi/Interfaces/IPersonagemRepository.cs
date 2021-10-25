using Sprint2___Projeto_HROADS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Interfaces
{
    interface IPersonagemRepository
    {
        List<Personagem> Listar();
        List<Personagem> ListarAll();
        Personagem BuscarPorId(int idPersonagem);
        void Cadastrar(Personagem novoPersonagem);
        void Atualizar(int idPersonagem, Personagem personagemAtualizado);
        void Deletar(int idPersonagem);
    }
}
