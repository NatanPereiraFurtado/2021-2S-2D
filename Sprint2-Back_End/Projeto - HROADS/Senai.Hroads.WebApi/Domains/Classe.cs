using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_HROADS.Domains
{
    public partial class Classe
    {
        public partial class Classe
        {
            public class ClasseDomain
            {
                ClasseHabilidades = new HashSet<ClasseHabilidadeDomain>();
        Personagens = new HashSet<Personagens>();
       }

            public byte IdClasse { get; set; }
            public string NomeClasse { get; set; }

            public virtual ICollection<ClasseHabilidadeDomain> ClasseHabilidades { get; set; }
            public virtual ICollection<Personagem> Personagens { get; set; }
        }
    }
}
