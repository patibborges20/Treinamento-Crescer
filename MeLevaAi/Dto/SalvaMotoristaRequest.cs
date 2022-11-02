using CPF.Validation.Attribute;
using MeLevaAi.Models;
using System.ComponentModel.DataAnnotations;

namespace MeLevaAi.Dto
{
    public class SalvaMotoristaRequest
    {
        [Required]
        public string NomeCompleto { get; set; }

        [EmailAddress(ErrorMessage = "O email está em um formato invalido")]
        public string Email { get; set; }

        [Range(typeof(DateTime), "01/01/1500", "01/01/3000", ErrorMessage = "Data de nascimento invalida", ConvertValueInInvariantCulture = true)]
        public DateTime DataNascimento { get; set; }

        [Cpf]
        public string Cpf { get; set; }
        public CarteiraHabilitacaoDto Carteira { get; set; }

    }
}
