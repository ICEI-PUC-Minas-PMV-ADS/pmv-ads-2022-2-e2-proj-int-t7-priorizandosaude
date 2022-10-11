using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSegundoSemestre.Models
{
    public class Entidade
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}
