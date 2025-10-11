
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

