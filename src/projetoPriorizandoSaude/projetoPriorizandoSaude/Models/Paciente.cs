using System.Collections.Generic;

namespace projetoPriorizandoSaude.Models
{
    public class Paciente : Entidade
    {
        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }

        public int CPF { get; set; }

        public List<Consulta> Consultas { get; set; }
    }
                        

}
