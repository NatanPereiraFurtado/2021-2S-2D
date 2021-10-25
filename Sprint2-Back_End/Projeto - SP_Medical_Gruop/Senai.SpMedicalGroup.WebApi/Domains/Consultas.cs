using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint2___Projeto_SP_Medical_Group.Domains
{
    public class Consultas
    {
        public partial class Consultum
        {
            public int IdConsulta { get; set; }
            public int? IdPaciente { get; set; }
            public int? IdMedico { get; set; }
            public string Descricao { get; set; }

            [Required(ErrorMessage = "Por favor, insira a data da consulta")]
            public DateTime DataConsulta { get; set; }
            public byte? IdSituacao { get; set; }

            public virtual Medico IdMedicoNavigation { get; set; }
            public virtual Paciente IdPacienteNavigation { get; set; }
            public virtual Situacao IdSituacaoNavigation { get; set; }
        }
    }
}
