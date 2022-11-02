
namespace MeLevaAi.Models
{
    public class Motorista
    {
        public string NomeCompleto { get; private set; } 
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public CarteiraHabilitacao Carteira { get; set; }
        public int Idade { get {
                var idade = DateTime.Now.Year - DataNascimento.Year;

                if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
                    idade -= 1;

                return idade;
            } }

        public Motorista(string nomeCompleto, string email, DateTime dataNascimento, string cpf, CarteiraHabilitacao carteira)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Carteira = carteira;
        }
    }
}
