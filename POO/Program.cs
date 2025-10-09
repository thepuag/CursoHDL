//var alhambraBeer = new Beer();

//alhambraBeer.Nombre = "Alhambra 1925";
//alhambraBeer.Precio = 3.2m;

//Console.WriteLine($"Cerveza {alhambraBeer.Nombre} vale ${alhambraBeer.Precio}");
//Console.WriteLine($"Cerveza {erdingerBeer.Nombre} vale ${erdingerBeer.Precio}");
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using POO.Negocio;

Beer erdingerBeer = new Beer("Erdinger", 3, -2, -1, 2)
{    
};

ExpiracionBeer coronita = new ExpiracionBeer("Coronita", 4, 3.2m, 8, new DateTime(2026, 1, 1), 300);

Bebida rivera = new Vino(2);

MostrarTipo(rivera);
MostrarTipo(coronita);

void MostrarTipo(Bebida bebida) => Console.WriteLine(bebida.GetCategoria());


