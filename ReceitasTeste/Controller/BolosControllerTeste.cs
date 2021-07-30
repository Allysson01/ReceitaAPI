using Microsoft.AspNetCore.Mvc;
using ReceitasAPI;
using ReceitasAPI.Controllers;
using ReceitasAPI.Producao.Interfaces;
using ReceitasTeste.Producao;
using System.Collections.Generic;
using Xunit;

namespace ReceitasTeste.Controller
{
    public class BolosControllerTeste
    {
        readonly BolosController _bolosController;
        readonly IBolosPedidos _pedidos;

        public BolosControllerTeste()
        {
            _pedidos = new ProducaoTeste();
            _bolosController = new BolosController(_pedidos);
        }

        [Fact]
        public void Get_RetornaListaDePedidos()
        {
            var resultado = _bolosController.ListaPedidosBolos().Result as OkObjectResult;

            Assert.IsType<List<PedidosAceitos>>(resultado.Value);            
        }
    }
}
