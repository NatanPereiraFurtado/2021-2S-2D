using Sprint2___Projeto_HROADS.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();
        List<Usuario> ListarComTipo();
        List<Usuario> ListarAll();
        Usuario BuscarPorId(int idUsuario);
        void Cadastrar(Usuario novoUsuario);
        void Atualizar(int idUsuario, Usuario usuarioAtualizado);
        void Deletar(int idUsuario);
        Usuario BuscarPorEmailSenha(string email, string senha);
    }
}
