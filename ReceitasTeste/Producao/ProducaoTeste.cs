using ReceitasAPI;
using ReceitasAPI.Models;
using ReceitasAPI.Producao.Interfaces;
using ReceitasAPI.Strategy;
using ReceitasAPI.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReceitasTeste.Producao
{
    public class ProducaoTeste : IBolosPedidos
    {
        List<BolosPedidos> _pedidos;
        public ProducaoTeste()
        {
            _pedidos = new List<BolosPedidos>()
            {
                new BolosPedidos(1,"Chocolate", "Maria"),
                new BolosPedidos(2, "Coco", "Pedro"),
                new BolosPedidos(3, "Baunilha", "Fernanda"),
                new BolosPedidos(4, "Chocolate", "Bruna"),
                new BolosPedidos(5, "Milho", "Marcia"),
                new BolosPedidos(6, "Festa", "Camila"),
                new BolosPedidos(7, "Baunilha", "Carlos"),
                new BolosPedidos(8, "Chocolate", "Percival"),
                new BolosPedidos(9, "Limão", "Ele"),
                new BolosPedidos(10, "Limão", "Gabriel"),
            };
        }

        public IEnumerable<ReceitasAPI.PedidosAceitos> ListaPedidosBolos()
        {
            var listaPedidos = new List<ReceitasAPI.PedidosAceitos>();

            var validadoresDeSabor = new List<IValidarSabor>
            {
                new BoloChocolate(),
                new BoloBaunilha(),
                new BoloCoco(),
                new BoloMilho(),
            };            

            var pedidoAceito = new ReceitasAPI.Strategy.Pedidos.PedidosAceitos(validadoresDeSabor);

            foreach (var pedido in _pedidos)
            {
                var resultado = pedidoAceito.RetornaPedidosAceitos(pedido);
                
                listaPedidos.Add(resultado);
            }            

            return listaPedidos.Where(w => w.TemValor).ToList();
        }

        public bool SalvaNovoPedido(BolosPedidos pedido)
        {
            throw new NotImplementedException();
        }
    }
}
