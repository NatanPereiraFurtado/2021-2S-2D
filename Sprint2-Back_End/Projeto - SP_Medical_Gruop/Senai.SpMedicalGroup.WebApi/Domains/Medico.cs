using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Domains
{
    public class Medico
    {

        public Medico()
        {
            Consulta = new HashSet<Consultas>();
        }

        public int IdMedico { get; set; }
        public int? IdUsuario { get; set; }
        public byte? IdClinica { get; set; }
        public short? IdEspecialidade { get; set; }
        public string Crm { get; set; }

        public virtual Clinica IdClinicaNavigation { get; set; }
        public virtual Especialidades IdEspecialidadeNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Consultas> Consulta { get; set; }
    }
}
