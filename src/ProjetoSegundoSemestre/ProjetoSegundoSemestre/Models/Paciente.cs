using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSegundoSemestre.Models
{
    public class Paciente : Entidade
    {
        [Required(ErrorMessage = "Obrigatório informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Email!")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Telefone!")]
        public int Telefone { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o CPF!")]
        public int CPF { get; set; }

        public List<Consulta> Consultas { get; set; }
    }
                        

}
