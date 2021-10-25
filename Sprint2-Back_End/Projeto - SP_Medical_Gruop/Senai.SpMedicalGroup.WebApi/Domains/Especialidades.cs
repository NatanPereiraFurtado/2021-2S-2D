using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Domains
{
    public class Especialidades
    {
        public class Especialidades
        {

            public Especialidades()
            {
                Medicos = new HashSet<Medico>();
            }

            public short IdEspecialidade { get; set; }
            public string TituloEspecialidade { get; set; }

            public virtual ICollection<Medico> Medicos { get; set; }
        }

    }
}
