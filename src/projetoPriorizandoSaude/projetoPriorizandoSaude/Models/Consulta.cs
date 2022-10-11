namespace projetoPriorizandoSaude.Models
{
    public class Consulta : Entidade
    {
        public StatusConsulta StatusConsulta { get; set; }

        public Agenda Agenda { get; set; }

        public Paciente Paciente { get; set; }
    }
                        

}
