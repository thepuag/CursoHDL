
namespace POO.Negocio
{
    public class Vino : Bebida
    {
        private const string Categoria = "Vino";
        public Vino(int cantidad) :base(cantidad){ }

        public override string GetCategoria() => Categoria;
    }
}
