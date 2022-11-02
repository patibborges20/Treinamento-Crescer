using MeLevaAi.Models;
using MeLevaAi.Repository;
using MeLevaAi.Services;
using Moq;

namespace Tests.Services
{
    public class MotoristaServiceTests
    {
        private readonly Mock<IMotoristaRepository> _motoristaRepository;

        public MotoristaServiceTests()
        {
            _motoristaRepository = new Mock<IMotoristaRepository>();
        }

        [Fact]
        public void ValidarMotoristaNulo()
        {
            //Arrange
            var motoristaService = new MotoristaService(_motoristaRepository.Object);
            Motorista motorista = null;
            //Act
            var response = motoristaService.ValidarCadastroMotorista(motorista);
            //Assert
            Assert.Equal("Verifique as informacoes preenchidas", response);

        }

        [Fact]
        public void MotoristaJaExistenteAoSalvar()
        {
            //Arrange
            var motoristaService = new MotoristaService(_motoristaRepository.Object);
            Motorista motorista = ObterMotorista();

            _motoristaRepository.Setup(x => x.Obter(motorista.Cpf)).Returns(motorista);
            //Act
            var response = motoristaService.ValidarCadastroMotorista(motorista);
            //Assert
            Assert.Equal("Ja existe um motorista com o cpf informado", response);

        }

        public Motorista ObterMotorista()
        {
            var carteira = new CarteiraHabilitacao("xxxx", CategoriaHabilitacao.A, new DateTime(2023, 01, 01));
            return new Motorista("Patricia", "patibborges@gmail", new DateTime(2002, 07, 18), "033.777.850-78", carteira);
        }
    }
}
