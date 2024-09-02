using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjAnnotation.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage ="Campo obrigatorio")]
        [StringLength(50)]
        [Display(Name ="Descrição:")]
        public string descricao { get; set; }

    }
}
