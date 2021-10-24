using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_Rental.Domain
{
    public class AluguelDomain
    {
        public int idAluguel { get; set; }
        public int idCLiente { get; set; }
        public int idVeiculos { get; set; }
        public int DataEmissao { get; set; }
        public int DataDevolucao { get; set; }
    }
}
