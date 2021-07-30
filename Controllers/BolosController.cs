using Microsoft.AspNetCore.Mvc;
using ReceitasAPI.Models;
using ReceitasAPI.Producao.Interfaces;
using System.Collections.Generic;

namespace ReceitasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BolosController : ControllerBase
    {
        readonly IBolosPedidos _bolos;
        public BolosController(IBolosPedidos bolos)
        {
            _bolos = bolos;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<BolosPedidos>> ListaPedidosBolos()
        {
            var resultado = _bolos.ListaPedidosBolos();
            return Ok(resultado);
        }

        [HttpPost]
        public ActionResult<IEnumerable<BolosPedidos>> SalvaNovoPedido([FromBody] BolosPedidos pedido)
        {
            var resultado = _bolos.SalvaNovoPedido(pedido);
            return Ok(resultado);
        }


    }
}
