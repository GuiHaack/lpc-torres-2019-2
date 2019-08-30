using System.ComponentModel.DataAnnotations;

namespace aula05_exercicio_static.Models
{
    public class CorrentistaModel
    {
        [Required]
        public int id { get; set; }

        [Required(ErrorMessage="O nome do correntista é obrigatório")]
        [Display(Name="Nome")]
        public string nome { get; set; }
    }
}