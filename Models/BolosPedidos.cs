namespace ReceitasAPI.Models
{
    public class BolosPedidos
    {
        public BolosPedidos(int id, string sabor, string cliente)
        {
            Id = id;
            Sabor = sabor;
            Cliente = cliente;
        }

        public int Id { get; }
        public string Sabor { get;}
        public string Cliente { get; }

        public bool EhChocolate { get => Sabor == "Chocolate"; }
        public bool EhBaunilha { get => Sabor == "Baunilha"; }
        public bool EhCoco { get => Sabor == "Coco"; }
        public bool EhMilho { get => Sabor == "Milho"; }
    }
}
