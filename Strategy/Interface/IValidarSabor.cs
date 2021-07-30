using ReceitasAPI.Models;

namespace ReceitasAPI.Strategy.Interface
{
    public interface IValidarSabor
    {
        bool QualSabor(BolosPedidos pedidos);
        decimal ValorBolo(BolosPedidos pedidos);
    }
}
