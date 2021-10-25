using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Domains
{
    public class Situacao
    {
        public Situacao()
        {
            Consulta = new HashSet<Consultas>();
        }

        public byte IdSituacao { get; set; }
        public string StatusSituacao { get; set; }

        public virtual ICollection<Consultas> Consulta { get; set; }
    }
}
