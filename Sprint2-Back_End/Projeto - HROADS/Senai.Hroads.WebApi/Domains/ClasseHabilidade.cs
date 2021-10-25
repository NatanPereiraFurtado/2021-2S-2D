using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Domains
{
    public partial class ClasseHabilidade
    {
        public short idClasseHabilidade { get; set; }
        public byte idClasse { get; set; }
        public byte IdHabilidade { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual HabilidadeDomain IdHabilidadeNavigation { get; set; }
    }
}
