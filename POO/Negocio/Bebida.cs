
namespace POO.Negocio
{
    public abstract class Bebida
    {
        public int Cantidad {  get; set; }

        public Bebida(int cantidad)
        {
            this.Cantidad = cantidad;
        }

        public string GetCantidad()
        {
            return Cantidad + " ml";
        }

        public abstract string GetCategoria();
    }    
}
