using ReceitasAPI.Models;
using ReceitasAPI.Producao.Interfaces;
using System;
using System.Collections.Generic;

namespace ReceitasAPI.Producao
{
    public class ListaBolosPedidos : IBolosPedidos
    {
        public IEnumerable<PedidosAceitos> ListaPedidosBolos()
        {
            throw new NotImplementedException();
        }

        public bool SalvaNovoPedido(BolosPedidos pedido)
        {
            throw new NotImplementedException();
        }
    }
}
