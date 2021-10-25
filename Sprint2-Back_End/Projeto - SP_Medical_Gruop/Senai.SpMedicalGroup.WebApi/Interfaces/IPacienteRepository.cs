using Sprint2___Projeto_SP_Medical_Group.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Interfaces
{
    interface IPacienteRepository
    {
        void Cadastrar(Paciente novoPaciente);
        List<Paciente> ListarTodos();
        Paciente BuscarPorId(int idPaciente);
        void Atualizar(Paciente pacienteAtualizado);
        void Deletar(int idUsuario);
    }
}
