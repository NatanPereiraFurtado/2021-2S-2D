using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Domains
{
    public partial class Habilidade
    {
        public Habilidade()
        {
            ClasseHabilidades = new HashSet<ClasseHabilidadeDomain>();
        }

        public byte IdHabilidade { get; set; }
        public byte? IdTipoHabilidade { get; set; }
        public string NomeHabilidade { get; set; }

        public virtual Tipohabilidade IdTipoHabilidadeNavigation { get; set; }
        public virtual ICollection<ClasseHabilidadeDomain> ClasseHabilidades { get; set; }
        public virtual ICollection<ClasseHabilidadeDomain> ClasseHabilidades { get; set; }
    }
}
