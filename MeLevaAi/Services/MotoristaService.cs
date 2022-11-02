using MeLevaAi.Models;
using MeLevaAi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeLevaAi.Services
{
    public class MotoristaService: IMotoristaService
    {
        private readonly IMotoristaRepository _motoristaRepository;

        public MotoristaService(IMotoristaRepository motoristaRepository)
        {
            _motoristaRepository = motoristaRepository;
        }

        public IEnumerable<Motorista> ListarPaginado(int qtdRegistroPagina = 10, int pagina = 0, bool flagAtiva = true)
        {
          var motoristas = _motoristaRepository.ListarPaginado();
            if (!motoristas.Any())
            {
                throw new BadHttpRequestException("Não há motoristas");
            }

            return motoristas;
        }

        public string ValidarCadastroMotorista(Motorista motorista)
        {
            if (motorista == null)
                return "Verifique as informacoes preenchidas";

            if (motorista.Carteira == null)
                return "Carteira de habilitacao nao informada";

            if (motorista.Idade < 18)
                return "O motorista precisa ser maior de idade";

            if (DateTime.Now.Date > motorista.Carteira.DataVencimento.Date)
                return "Carteira de habilitacao expirada";

            var existeMotoristaMesmoCpf = _motoristaRepository.Obter(motorista.Cpf) != null ;

            if (existeMotoristaMesmoCpf)
                return "Ja existe um motorista com o cpf informado";

            return string.Empty;

        }
    }
}
