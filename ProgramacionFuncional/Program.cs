// Ejemplo de programación funcional y uso de delegates en C#
using System.Threading.Channels;

// Fecha de ejemplo creada manualmente
DateTime datito = new DateTime(2025,11,12);

// Imprime la fecha creada más un día
Console.WriteLine(CreadoMasUno(datito));
// Imprime la fecha actual más un día
Console.WriteLine(ActualMasUno());
// Espera 1 segundo para mostrar que ActualMasUno cambia con el tiempo
await Task.Delay(1000);
Console.WriteLine(ActualMasUno());

// Función que recibe una fecha y devuelve la fecha + 1 día
DateTime CreadoMasUno(DateTime time)
{
    return time.AddDays(1);
}
// Expresión lambda (método de una sola línea) que devuelve la fecha actual + 1 día
DateTime ActualMasUno() => DateTime.Now.AddDays(1);

// Creación de objetos de ejemplo
Cositas heineken = new Cositas{
    Nombre = "Heineken",
    Cantidad = 2
};

Cositas mercedes = new Cositas("Mercedes", 2);

// Se modifica el objeto original (se mostrará en mayúsculas)
ModificarObjetoOriginal(heineken);
// Ejemplos comentados de impresión del estado de los objetos
//Console.WriteLine($"El nombre de heineken despues de usar ModificarNombreMayusculas > {heineken.Nombre}");

//Console.WriteLine($"El nombre de mercedes antes de usar metodo > {mercedes.Nombre}");
//Console.WriteLine($"Le paso el objeto mercedes y me devuelve una copia con el nombre en mayusculas > {NoModificaObjeto(mercedes).Nombre}");
//Console.WriteLine($"El nombre de mercedes despues de usar metodo > {mercedes.Nombre}");

// Asignación de un método a una variable (se puede invocar más tarde)
var t = NoModificaObjeto;

// Ejemplo de Action que apunta al método que modifica el objeto original
Action<Cositas> d = ModificarObjetoOriginal;

Console.WriteLine("Aqui debajo esta el ejemplo de Action");

// Invocación del delegate Action sobre el objeto mercedes
d(mercedes);

// Action con tipo string que apunta a Console.WriteLine (método existente)
Action<string> muestra = Console.WriteLine;
muestra("Hola");
//Console.WriteLine(t(mercedes).Nombre);
// Ejemplo de lambda en una Action que compone el mensaje
Action<String> muestraNombre = nombre => muestra($"Hola {nombre}");
muestraNombre("Paquito");

// Func delegate que recibe dos enteros y devuelve multiplicación (int)
Func<int, int, int> mult = (a, b) => a*b;
// Mostrar el resultado convirtiéndolo a cadena
muestra(mult(4, 2).ToString());

// Func delegate que devuelve string (ejemplo con bloque de código)
Func<int, int, string> multString = (a, b) =>
{
    var resultado = (a*b).ToString();
    return resultado;
};

muestra(multString(10, 50));

// Lista de números de ejemplo
List<int> listaNumeros = new List<int>() { 2,7,12,15,20,21,22};

// Uso de la función Filtrar pasando una lambda como condición
var numbers2 = Filtrar(listaNumeros, number => number % 2 == 0);

// Imprime los elementos filtrados
foreach (var item in numbers2)
{
    Console.WriteLine(item);
}


// Función que filtra una lista usando una condición pasada como Func<int,bool>
List<int> Filtrar(List<int> listaEnteros, Func<int,bool> condicion) 
{
    var listaResultante = new List<int>();
    foreach (var elemento in listaEnteros)
    {
        // Si la condición se cumple, agregar a la lista resultante
        if(condicion(elemento))
        {
            listaResultante.Add(elemento);
        }
    }
    return listaResultante;
}

// Método que modifica el objeto original (mutación del estado)
void ModificarObjetoOriginal(Cositas objeto) 
{
    objeto.Nombre = objeto.Nombre.ToUpper();
    Console.WriteLine(objeto.Nombre);
}

// Método que NO modifica el objeto original: crea y devuelve una copia
Cositas NoModificaObjeto(Cositas objeto)
{
    Cositas newObjeto = new Cositas(); 
    newObjeto.Nombre = objeto.Nombre.ToUpper(); 
    
    return newObjeto;
}

// Clase simple de ejemplo
class Cositas
{
    // Propiedades públicas
    public string Nombre {  get; set; }
    public int Cantidad { get; set; }

    // Constructores
    public Cositas() { }
    public Cositas(string nombre, int cantidad) 
    {  
        Nombre = nombre; 
        Cantidad = cantidad;
    }
}



