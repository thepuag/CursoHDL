
using POO.Negocio;

Servicios patatatillas = new Servicios(120, 13);
Beer erdingerBeer = new Beer("Erdinger", 3, -2, -1, 2)
{
};

VenderAlgo(patatatillas);
EnviarAlgo(erdingerBeer);

IVendible[] cositas = new IVendible[]
{
    erdingerBeer,
    patatatillas

};

Beer basica = new Beer("Ipa", 3, 4.2M,120,1);

VenderMuchos(cositas);

ExpiracionBeer coronita = new ExpiracionBeer("Coronita", 4, 3.2m, 8, new DateTime(2026, 1, 1), 300);

Bebida rivera = new Vino(2);

MostrarTipo(rivera);
MostrarTipo(coronita);

void MostrarTipo(Bebida bebida) => Console.WriteLine(bebida.GetCategoria());

void EnviarAlgo(IEnviable elemento) => elemento.Enviar();

void VenderAlgo(IVendible elemento) => Console.WriteLine(elemento.GetPrecio());
void VenderMuchos(IVendible[] elementos)
{
    if (elementos != null)
    {
        Console.WriteLine("Cuenta total:");
        foreach (IVendible elemento in elementos)
        {
            Console.WriteLine(elemento.GetPrecio());
        }
    }
}
// Pruebas de statics
Console.WriteLine("---- EJERCICIO STATICS ----");
Console.WriteLine(Beer.CantidadDeObjetos);

Console.WriteLine($"Probando la multiplicacion de metodo static > {OperacionesAuxiliares.Multiplicacion(2,3)}");

// Colecciones
Console.WriteLine("---- EJERCICIO COLECCIONES ----");

var pipas = new Elementos<int>(4);

pipas.Add(121);
pipas.Add(345);
pipas.Add(1212131);
pipas.Add(0000);

pipas.Get();

