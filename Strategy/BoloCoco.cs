using ReceitasAPI.Models;
using ReceitasAPI.Strategy.Interface;

namespace ReceitasAPI.Strategy
{
    public class BoloCoco : IValidarSabor
    {
        public bool QualSabor(BolosPedidos pedidos)
        {
            return pedidos.EhCoco;
        }
        public decimal ValorBolo(BolosPedidos pedidos)
        {
            return 13.70M;
        }
    }
}
