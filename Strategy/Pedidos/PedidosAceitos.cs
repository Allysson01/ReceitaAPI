using ReceitasAPI.Models;
using ReceitasAPI.Strategy.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ReceitasAPI.Strategy.Pedidos
{
    public class PedidosAceitos
    {
        readonly IEnumerable<IValidarSabor> _sabores;
        public PedidosAceitos(IEnumerable<IValidarSabor> sabores)
        {
            _sabores = sabores;
        }

        public ReceitasAPI.PedidosAceitos RetornaPedidosAceitos(BolosPedidos pedidos)
        {
            var pedidosAceitos = new ReceitasAPI.PedidosAceitos(pedidos);

            var saborBolo = _sabores.Where(x => x.QualSabor(pedidos)).ToList();

            foreach (var sabor in saborBolo)
            {
                var valor = sabor.ValorBolo(pedidos);

                pedidosAceitos.ValorDoBolo(valor);
            }

            return pedidosAceitos;
        }
    }
}
