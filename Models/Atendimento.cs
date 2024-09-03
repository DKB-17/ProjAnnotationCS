using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ProjAnnotation.Models
{
    [Table("Atendimentos")]
    public class Atendimento
    {

        [Display(Name = "ID: ")]
        public int Id { get; set; }
        
        [Display(Name = "Aluno: ")]
        public Aluno aluno { get; set; }
        [ForeignKey("Atendimento_Aluno_FK")]
        [Display(Name = "Aluno: ")]
        public int alunoId {  get; set; }


        [Display(Name = "Sala: ")]
        public Sala sala { get; set; }
        [ForeignKey("Atendimento_Sala_FK")]
        [Display(Name = "Sala: ")]
        public int salaId { get; set; }


        [Display(Name = "Data hora: ")]
        public DateTime dataHora { get; set; }
    }
}
