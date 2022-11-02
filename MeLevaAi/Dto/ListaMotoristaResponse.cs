namespace MeLevaAi.Dto
{
    public class ListaMotoristaResponse
    {
        public IEnumerable<MotoristaDto> Motoristas { get; set; }
        public int Pagina { get; set; }
        public int QtdRegistroPagina { get; set; }
    }
}
