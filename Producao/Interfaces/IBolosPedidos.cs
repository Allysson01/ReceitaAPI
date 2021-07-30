using ReceitasAPI.Models;
using System.Collections.Generic;

namespace ReceitasAPI.Producao.Interfaces
{
    public interface IBolosPedidos
    {
        IEnumerable<PedidosAceitos> ListaPedidosBolos();

        bool SalvaNovoPedido(BolosPedidos pedido);
    }
}
