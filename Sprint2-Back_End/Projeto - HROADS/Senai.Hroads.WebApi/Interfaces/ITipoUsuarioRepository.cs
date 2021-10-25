using Sprint2___Projeto_HROADS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();
        TipoHabilidade BuscarPorId(int idTipoUsuario);
        void Cadastrar(TipoUsuario novoTipoUsuario);
        void Atualizar(int idTipoUsuario, TipoUsuario tipoUsarioAtualização);
        void Deletar(int idTipoUsuario);
    }
}
