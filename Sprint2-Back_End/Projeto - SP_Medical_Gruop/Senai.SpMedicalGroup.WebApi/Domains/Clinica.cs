using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Domains
{
    public class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public byte IdClinica { get; set; }

        [Required(ErrorMessage = "Por favor, insira o endereço da clínica")]
        public string EnderecoClinica { get; set; }

        [Required(ErrorMessage = "Por favor, insira o horário de abertura clínica")]
        public TimeSpan HoraAbre { get; set; }

        [Required(ErrorMessage = "Por favor, insira o horário de fechamento da clínica")]
        public TimeSpan HoraFecha { get; set; }

        [Required(ErrorMessage = "Por favor, insira o CNPJ da clínica")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Por favor, insira o Nome Fantasia da clínica")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Por favor, insira a Razão Social da clínica")]
        public string RazaoSocial { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
