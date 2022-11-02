using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeLevaAi.Models
{
    public class CarteiraHabilitacao
    {
        public string NumeroCnh { get; private set; }
        public CategoriaHabilitacao Categoria { get; set; }
        public DateTime DataVencimento { get; set; }
        public CarteiraHabilitacao(string numeroCnh, CategoriaHabilitacao categoria, DateTime dataVencimento)
        {
            NumeroCnh = numeroCnh;
            Categoria = categoria;
            DataVencimento = dataVencimento;
        }
    }
    public enum CategoriaHabilitacao: int
    { 
        A,
        B,
        AB,
        C,
        D,
        E
    }
}
