using MeLevaAi.Models;
using System.ComponentModel.DataAnnotations;

namespace MeLevaAi.Dto
{
    public class CarteiraHabilitacaoDto
    {

        [Required(ErrorMessage ="O numero do CNH é obrigatórios", AllowEmptyStrings = false)]
        public string? NumeroCnh { get; set; }
        public CategoriaHabilitacao Categoria{ get; set; }

        [Range(typeof(DateTime), "01/01/1500", "01/01/3000", ErrorMessage = "Data de nascimento invalida", ConvertValueInInvariantCulture = true)]
        public DateTime DataVencimento { get; set; }
    }
}
