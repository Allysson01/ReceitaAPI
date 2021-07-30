using ReceitasAPI.Models;
using ReceitasAPI.Strategy.Interface;

namespace ReceitasAPI.Strategy
{
    public class BoloMilho : IValidarSabor
    {
        public bool QualSabor(BolosPedidos pedidos)
        {
            return pedidos.EhMilho;
        }
        public decimal ValorBolo(BolosPedidos pedidos)
        {
            return 10.90M;
        }
    }
}
