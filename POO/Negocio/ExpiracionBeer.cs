
namespace POO.Negocio
{
    public class ExpiracionBeer : Beer
    {
         
        public DateTime FechaExpiracion {  get; set; }
        public ExpiracionBeer (string nombre, decimal precio, decimal alcohol, int stock, DateTime fechaExpiracion, int cantidad) 
            : base(nombre, precio, alcohol, stock, cantidad)
        {
            FechaExpiracion = fechaExpiracion;
        }

        public override string GetInfo()
        {
            return "Nombre: " + Nombre + " | Precio: $" + Precio + " | Grados: " + Alcohol + "% | Cantidad: " + Stock + " | FC: " + FechaExpiracion;
        }
    }
}
