using Sprint2___Projeto_SP_Medical_Group.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Interfaces
{
    interface IClinicaRepository
    {

        void Cadastrar(Clinica novaClinica);
        List<Clinica> ListarTodas();
        Clinica BuscarPorId(int idClinica);
        void Atualizar(Clinica clinicaAtualizada);
        void Deletar(int idClinica);
    }
}
