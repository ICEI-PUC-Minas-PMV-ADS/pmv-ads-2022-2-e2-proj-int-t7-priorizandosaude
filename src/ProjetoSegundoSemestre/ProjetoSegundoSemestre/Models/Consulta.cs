using System.ComponentModel.DataAnnotations;

namespace ProjetoSegundoSemestre.Models
{
    public class Consulta : Entidade
    {
        [Required(ErrorMessage = "Obrigatório informar o Status!")]
        public StatusConsulta Status { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Paciente!")]
        public Paciente Paciente { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Agenda!")]
        public Agenda Agenda { get; set; }

    }
}
