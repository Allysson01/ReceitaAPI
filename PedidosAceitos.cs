using ReceitasAPI.Models;

namespace ReceitasAPI
{
    public class PedidosAceitos
    {
        public PedidosAceitos(BolosPedidos bolosPedidos)
        {
            BolosPedidos = bolosPedidos;
            Valor = 0;
        }

        public BolosPedidos BolosPedidos { get; set; }

        public decimal Valor { get; private set; }

        public bool TemValor {get => Valor > 0;}

        internal void ValorDoBolo(decimal valor)
        {
            Valor += valor;
        }
    }
}
