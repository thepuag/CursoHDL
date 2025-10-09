using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Negocio
{
    internal class ExpiracionBeer : Beer
    {
        public DateTime FechaExpiracion {  get; set; }
        public ExpiracionBeer (string nombre, decimal precio, decimal alcohol, int stock, DateTime fechaExpiracion) : base(nombre, precio, alcohol, stock)
        {
            FechaExpiracion = fechaExpiracion;
        }

        public override string GetInfo()
        {
            return "Nombre: " + Nombre + " | Precio: $" + Precio + " | Grados: " + Alcohol + "% | Cantidad: " + Stock + " | FC: " + FechaExpiracion;
        }
    }
}
