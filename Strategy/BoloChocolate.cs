using ReceitasAPI.Models;
using ReceitasAPI.Strategy.Interface;

namespace ReceitasAPI.Strategy
{
    public class BoloChocolate : IValidarSabor
    {
        public bool QualSabor(BolosPedidos pedidos)
        {
            return pedidos.EhChocolate;
        }
        public decimal ValorBolo(BolosPedidos pedidos)
        {
            return 14.90M;
        }
    }
}
