// See https://aka.ms/new-console-template for more information
int limite = 5;
var beers = new string[limite];
int iBeers = 0;
int op = 0;

do
{
    //Console.Clear();
    ShowMenu();
    var input = Console.ReadLine();
    if(!int.TryParse(input, out op))
    {
        Console.WriteLine("Introduce una opcion valida");
        Console.WriteLine("Pulsa una tecla para continuar");
        Console.ReadLine();

        continue;
    }

    switch (op)
    {
        case 1:
            AddBeers(beers, ref iBeers, limite);
            break;
        case 2:
            ShowBeers(beers, iBeers);
            break;
        case 3:
            
            Console.WriteLine("Adios!");
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break ;
    }

} while (op != 3);

void ShowMenu()
{
    Console.WriteLine("1 -> Agregar nombre.");
    Console.WriteLine("2 -> Mostrar nombre.");
    Console.WriteLine("3 -> Salir.");
}

void ShowBeers(string[] beers, int iBeers){
    Console.WriteLine("Nombres agregados:");
    for (int i = 0; i < iBeers; i++)
    {
        Console.WriteLine(beers[i]);
    }
}

void AddBeers(string[] beers, ref int iBeers, int limite)
{
    if (iBeers < limite)
    {
        Console.WriteLine("Ingrese el nombre a agregar:");
        beers[iBeers] = Console.ReadLine();
        iBeers++;
    }
    else
    {
        Console.WriteLine("No se pueden agregar más nombres, límite alcanzado.");
    }
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
}
