using ReceitasAPI.Models;
using ReceitasAPI.Strategy.Interface;

namespace ReceitasAPI.Strategy
{
    public class BoloBaunilha : IValidarSabor
    {
        public bool QualSabor(BolosPedidos pedidos)
        {
            return pedidos.EhBaunilha;
        }
        public decimal ValorBolo(BolosPedidos pedidos)
        {
            return 12.50M;
        }
    }
}
