using Sprint2___Projeto_SP_Medical_Group.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Interfaces
{
    interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidades novaEspecialidade);
        List<Especialidades> ListarTodas();
        Especialidades BuscarPorId(int idEspecialidade);
        void Atualizar(Especialidades especialidadeAtt);
        void Deletar(int idEspecialidade);
    }
}
