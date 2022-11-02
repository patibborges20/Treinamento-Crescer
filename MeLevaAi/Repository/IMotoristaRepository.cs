using MeLevaAi.Models;

namespace MeLevaAi.Repository
{
    public interface IMotoristaRepository
    {
        public IEnumerable<Motorista> ListarPaginado(int qtdRegistroPagina = 10, int pagina = 0, bool flagAtiva = true);
        public Motorista Obter(string cpf);
        public Motorista Salvar(Motorista motorista);
        public Motorista Alterar(string cpf, Motorista motorista);
        public void Deletar(string cpf);
    }
}
