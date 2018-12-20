using everis.SimpleProject.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace everis.SimpleProject.Domain.Model
{
    public class EsforcoProjeto : Entity
    {

        [Required]
        public int IdProjetoPessoa { get; set; }

        [Required]
        public ProjetoPessoa ProjetoPessoa { get; set; }

        [Required]
        public short QtdHorasDia { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        [Required]
        public DateTime DataRegistro { get; set; }
    }
}