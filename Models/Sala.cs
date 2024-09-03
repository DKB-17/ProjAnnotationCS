using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjAnnotation.Models
{
    [Table("Salas")]
    public class Sala
    {

        public enum TipoSituação { Liberada, Ocupada, Reservada, Manutenção, Outra}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Descricao: ")]
        public string descricao { get; set; }

        [Display(Name = "Quantidade de equipamentos: ")]
        public int equipamentos { get; set; }

        [Display(Name = "Tipo situação: ")]
        public TipoSituação situação { get; set; }


    }
}
