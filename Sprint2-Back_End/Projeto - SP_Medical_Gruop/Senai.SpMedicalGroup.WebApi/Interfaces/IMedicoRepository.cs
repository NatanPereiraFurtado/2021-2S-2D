using Sprint2___Projeto_SP_Medical_Group.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Interfaces
{
    interface IMedicoRepository
    {
        void Cadastrar(Medico novoMedico);
        List<Medico> ListarTodos();
        Medico BuscarPorId(int idMedico);
        void Atualizar(Medico medicoAtualizado);
        void Deletar(int idMedico);
    }
}
