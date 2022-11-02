using MeLevaAi.Models;

namespace MeLevaAi.Dto
{
    public class MotoristaDto
    {
        public string NomeCompleto { get;  set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public CarteiraHabilitacaoDto Carteira { get; set; }
    }
}
