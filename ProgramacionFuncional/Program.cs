using System.Threading.Channels;

DateTime datito = new DateTime(2025,11,12);

Console.WriteLine(CreadoMasUno(datito));
Console.WriteLine(ActualMasUno());
await Task.Delay(1000);
Console.WriteLine(ActualMasUno());
DateTime CreadoMasUno(DateTime time)
{
    return time.AddDays(1);
}
DateTime ActualMasUno() => DateTime.Now.AddDays(1);
Cositas heineken = new Cositas{
    Nombre = "Heineken",
    Cantidad = 2
};

Cositas mercedes = new Cositas("Mercedes", 2);

ModificarObjetoOriginal(heineken);
//Console.WriteLine($"El nombre de heineken despues de usar ModificarNombreMayusculas > {heineken.Nombre}");

//Console.WriteLine($"El nombre de mercedes antes de usar metodo > {mercedes.Nombre}");
//Console.WriteLine($"Le paso el objeto mercedes y me devuelve una copia con el nombre en mayusculas > {NoModificaObjeto(mercedes).Nombre}");
//Console.WriteLine($"El nombre de mercedes despues de usar metodo > {mercedes.Nombre}");

var t = NoModificaObjeto;

Action<Cositas> d = ModificarObjetoOriginal;

Console.WriteLine("Aqui debajo esta el ejemplo de Action");

d(mercedes);

Action<string> muestra = Console.WriteLine;
muestra("Hola");
//Console.WriteLine(t(mercedes).Nombre);
Action<String> muestraNombre = nombre => muestra($"Hola {nombre}");
muestraNombre("Paquito");

Func<int, int, int> mult = (a, b) => a*b;
muestra(mult(4, 2).ToString());

Func<int, int, string> multString = (a, b) =>
{
    var resultado = (a*b).ToString();
    return resultado;
};

muestra(multString(10, 50));

List<int> listaNumeros = new List<int>() { 2,7,12,15,20,21,22};

var numbers2 = Filtrar(listaNumeros, number => number % 2 == 0);

foreach (var item in numbers2)
{
    Console.WriteLine(item);
}

List<int> Filtrar(List<int> listaEnteros, Func<int,bool> condicion) 
{
    var listaResultante = new List<int>();
    foreach (var elemento in listaEnteros)
    {
        if(condicion(elemento))
        {
            listaResultante.Add(elemento);
        }
    }
    return listaResultante;
}

void ModificarObjetoOriginal(Cositas objeto) 
{
    objeto.Nombre = objeto.Nombre.ToUpper();
    Console.WriteLine(objeto.Nombre);
}
Cositas NoModificaObjeto(Cositas objeto)
{
    Cositas newObjeto = new Cositas(); 
    newObjeto.Nombre = objeto.Nombre.ToUpper(); 
    
    return newObjeto;
}

class Cositas
{
    public string Nombre {  get; set; }
    public int Cantidad { get; set; }

    public Cositas() { }
    public Cositas(string nombre, int cantidad) 
    {  
        Nombre = nombre; 
        Cantidad = cantidad;
    }
}



