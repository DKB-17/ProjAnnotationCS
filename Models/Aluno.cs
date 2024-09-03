using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjAnnotation.Models
{

    [Table("Alunos")]
    public class Aluno
    {
        public enum Periodo { Manha, Tarde, Noite }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="ID: ")]
        public int id { get; set; }
        [Required(ErrorMessage = "Campo nome é obrigatorio...")]
        [StringLength(40, ErrorMessage = "Tamanho maximo 40 caracteres")]
        [Display(Name ="Nome: ")]
        public string nome { get; set; }
        [Display(Name ="Data aniversario: ")]
        public DateTime aniversario { get; set; }

        [Display(Name = "Curso: ")]
        public Curso curso { get; set; }
        [Display(Name = "Curso: ")]
        public int cursoID { get; set; }

        [Display(Name = "Periodo: ")]
        public Periodo periodo { get; set; }

    }
}
