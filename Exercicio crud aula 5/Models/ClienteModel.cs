using System.ComponentModel.DataAnnotations;

namespace aula05_exercicio_static.Models
{
    public class ClienteModel
    {
        [Required]
        public int id { get; set; }

        [Required(ErrorMessage="O nome do cliente é obrigatório")]
        [Display(Name="Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage="O cpf do cliente é obrigatório")]
        [Display(Name="CPF")]
        public string cpf { get; set; }
    }
}