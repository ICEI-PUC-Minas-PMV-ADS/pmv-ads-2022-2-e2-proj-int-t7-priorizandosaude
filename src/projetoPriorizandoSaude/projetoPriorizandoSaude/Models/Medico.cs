using System.Collections.Generic;

namespace projetoPriorizandoSaude.Models
{
    public class Medico : Entidade
    {
        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }

        public Especialidade Especialidade { get; set; }

        public int CRM { get; set; }

        public string Endereco { get; set; }

        public List<Agenda> Agendas { get; set; }

    }
}
