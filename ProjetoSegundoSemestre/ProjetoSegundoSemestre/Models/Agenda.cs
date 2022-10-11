using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSegundoSemestre.Models
{
    public class Agenda : Entidade
    {
        [Required(ErrorMessage = "Obrigatório informar o DataHoraInicioConsulta!")]
        public DateTime DataHoraInicioConsulta { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o DataHoraFimConsultaConsulta!")]
        public DateTime DataHoraFimConsultaConsulta { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Medico!")]
        public Medico Medico { get; set; }
    }
}
