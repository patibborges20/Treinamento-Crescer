using MeLevaAi.Models;


namespace MeLevaAi.Repository
{
    public class MotoristaRepository: IMotoristaRepository
    {
        public static CarteiraHabilitacao carteiraPati = new CarteiraHabilitacao("xxx", CategoriaHabilitacao.A, new DateTime(2023, 03, 16));
        public static Motorista motorista = new Motorista("patricia borges", "patibborges@gmail.com", new DateTime(1994, 07, 19), "033.777.850-78", carteiraPati);

        public static CarteiraHabilitacao carteiraAnonimo = new CarteiraHabilitacao("xxx", CategoriaHabilitacao.A, new DateTime(2023, 03, 16));
        public static Motorista motoristaAnonimo = new Motorista("patricia borges", "patibborges@gmail.com", new DateTime(1994, 07, 19), "033.777.850-78", carteiraPati);

        public static List<Motorista> _motoristas = new List<Motorista>
        {
            motorista,
            motoristaAnonimo
        };

        public IEnumerable<Motorista> ListarPaginado(int qtdRegistroPagina = 10, int pagina = 0, bool flagAtiva = true)
        {

            return _motoristas.Skip(pagina * qtdRegistroPagina).Take(qtdRegistroPagina);

        }

        public Motorista Obter(string cpf)
        {
            return _motoristas.Find(x => x.Cpf == cpf);
        }
        public Motorista Salvar(Motorista motorista)
        {
            _motoristas.Add(motorista);
            return motorista;
        }

        public Motorista Alterar(string cpf, Motorista motorista)
        {
            return _motoristas.Where(x => x.Cpf == cpf).Select(x => { x = motorista; return x; }).FirstOrDefault();
        }

        public void Deletar(string cpf)
        {
            var motoristaIndex = _motoristas.FindIndex(x => x.Cpf == cpf);
            _motoristas.RemoveAt(motoristaIndex);
        }
    }
}
