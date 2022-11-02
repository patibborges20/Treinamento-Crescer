using MeLevaAi.Dto;
using MeLevaAi.Mappers;
using MeLevaAi.Models;
using MeLevaAi.Repository;
using MeLevaAi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeLevaAi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristaController : ControllerBase
    {

        private readonly IMotoristaRepository _motoristaRepository;
        private  IMotoristaService _motoristaService;

        public MotoristaController(IMotoristaRepository motoristaRepository, IMotoristaService motoristaService)
        {
            _motoristaRepository = motoristaRepository;
            _motoristaService = motoristaService;
        }
 
        [HttpGet]
        public ActionResult<ListaMotoristaResponse> Get(int qtdRegistroPagina = 10, int pagina = 0)
        {
            try
            {
                var motoristas =  _motoristaService.ListarPaginado(qtdRegistroPagina, pagina, false);
                return motoristas.Map(pagina, qtdRegistroPagina);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }   
        }

        [HttpGet("{cpf}")]
        public Motorista Get(string cpf)
        {
            return _motoristaRepository.Obter(cpf);
        }

        // POST api/<MotoristaController>
        [HttpPost]
        public ActionResult<Motorista> Post([FromBody] SalvaMotoristaRequest request)
        {
            var motorista = request.Map();
            var Validacao = _motoristaService.ValidarCadastroMotorista(motorista);
            _motoristaRepository.Salvar(motorista);

            if (!String.IsNullOrEmpty(Validacao))
                return BadRequest(Validacao);

            _motoristaRepository.Salvar(motorista);
            return Ok(motorista);
        }


        // PUT api/<MotoristaController>/5
        [HttpPut("{cpf}")]
        public  Motorista Put(string cpf,Motorista motorista)
        {
            return  _motoristaRepository.Alterar(cpf, motorista); 
        }

        // DELETE api/<MotoristaController>/5
        [HttpDelete("{cpf}")]
        public IActionResult Delete(string cpf)
        {
            _motoristaRepository.Deletar(cpf);
            return Ok();
        }
    }
}
