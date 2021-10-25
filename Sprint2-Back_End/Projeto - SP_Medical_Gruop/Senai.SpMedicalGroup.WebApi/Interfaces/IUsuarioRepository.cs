using Microsoft.AspNetCore.Http;
using Sprint2___Projeto_SP_Medical_Group.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);
        void Cadastrar(Usuario novoUsuario);
        List<Usuario> ListarTodos();
        Usuario BuscarPorId(int idUsuario);
        void Atualizar(Usuario usuarioAtualizado);
        void Deletar(int idUsuario);

        void SalvarPerfilDir(IFormFile foto, int idUsuario);
        string ConsultarPerfilDir(int idUsuario);
    }
}
