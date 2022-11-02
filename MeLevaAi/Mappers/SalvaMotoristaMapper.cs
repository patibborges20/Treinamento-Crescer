using MeLevaAi.Dto;
using MeLevaAi.Models;

namespace MeLevaAi.Mappers
{
    public static class SalvaMotoristaMapper
    {
        public static Motorista Map(this SalvaMotoristaRequest request)
        {
            return new Motorista(request.NomeCompleto, request.Email, request.DataNascimento, request.Cpf, new CarteiraHabilitacao(request.Carteira.NumeroCnh, request.Carteira.Categoria, request.Carteira.DataVencimento));
        }
    }
}
