using MeLevaAi.Models;

namespace MeLevaAi.Services
{
    public interface IMotoristaService
    {
        public string ValidarCadastroMotorista(Motorista motorista);

        public IEnumerable<Motorista> ListarPaginado(int qtdRegistroPagina = 10, int pagina = 0, bool flagAtiva = true);
    }
}
