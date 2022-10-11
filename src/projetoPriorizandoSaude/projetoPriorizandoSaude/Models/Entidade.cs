using System;

namespace projetoPriorizandoSaude.Models
{
    public class Entidade
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
