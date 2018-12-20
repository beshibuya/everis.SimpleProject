using everis.SimpleProject.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace everis.SimpleProject.Domain.Model
{
    public class Colaborador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdColaborador { get; set; }

        [Required]
        public int IdPessoa { get; set; }

        [Required]
        public Pessoa Pessoa { get; set; }

        public string Racf { get; set; }

        [Required]
        public string EmailCorp { get; set; }

        [Required]
        public int Funcional { get; set; }

        public string NomeMaquina { get; set; }

        [Required]
        public EnumFuncao Funcao { get; set; }

        [Required]
        public EnumPerfil Perfil { get; set; }

        [Required]
        public bool Disponivel { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}