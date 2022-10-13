using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSegundoSemestre.Models
{
    public class Medico : Entidade
    {
        [Required(ErrorMessage = "Obrigatório informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Telefone!")]
        [DataType(DataType.PhoneNumber)]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Especialidade!")]
        public Especialidade Especialidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o CRM!")]
        public int CRM { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Endereco!")]
        public string Endereco { get; set; }

        public List<Agenda> Agendas { get; set; }

    }
}
