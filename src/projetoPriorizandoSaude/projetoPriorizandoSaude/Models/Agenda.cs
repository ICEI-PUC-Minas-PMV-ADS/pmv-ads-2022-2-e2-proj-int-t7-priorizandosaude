using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projetoPriorizandoSaude.Models
{
    public class Agenda : Entidade
    {
        public DateTime DataHoraInicioConsulta { get; set; }
        
        public DateTime DataHoraFimConsulta { get; set; }

        public Medico Medico { get; set; }

       public List<Consulta> Consultas { get; set; }
    }
                        

}
