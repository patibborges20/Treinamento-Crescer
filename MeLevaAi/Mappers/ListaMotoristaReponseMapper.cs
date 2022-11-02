using MeLevaAi.Dto;
using MeLevaAi.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;

namespace MeLevaAi.Mappers
{
    public static  class ListaMotoristaReponseMapper
    {
        public static ListaMotoristaResponse Map(this IEnumerable<Motorista> motoristas, int pagina, int qtdPagina)
        {
            return new ListaMotoristaResponse
            {
                Motoristas =
                 motoristas.Select(x => new MotoristaDto()
                 {
                     Cpf = x.Cpf,
                     DataNascimento = x.DataNascimento,
                     Email = x.Email,
                     NomeCompleto = x.NomeCompleto,
                     Carteira =
                    new CarteiraHabilitacaoDto
                    {
                        Categoria = x.Carteira.Categoria,
                        DataVencimento = x.Carteira.DataVencimento,
                        NumeroCnh = x.Carteira.NumeroCnh,
                    }
                 }),
                Pagina = pagina,
                QtdRegistroPagina = qtdPagina
            };
        }

    }
}
