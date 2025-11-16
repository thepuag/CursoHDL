DateTime datito = new DateTime(2025,11,12);

Console.WriteLine(CreadoMasUno(datito));
Console.WriteLine(ActualMasUno());
await Task.Delay(5000);
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

ModificarNombreMayusculas(heineken);
Console.WriteLine($"El nombre de heineken despues de usar ModificarNombreMayusculas > {heineken.Nombre}");
ModificarNombreMAy2(mercedes);
Console.WriteLine($"El nombre de heineken despues de usar ModificarNombreMAy2 > {mercedes.Nombre}");
void ModificarNombreMayusculas(Cositas objeto) 
{
    objeto.Nombre = objeto.Nombre.ToUpper();
    Console.WriteLine(objeto.Nombre);
}
void ModificarNombreMAy2(Cositas objeto)
{
    var newObjeto = objeto.Nombre.ToUpper(); 
    
    Console.WriteLine(newObjeto);
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



