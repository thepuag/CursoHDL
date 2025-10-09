
namespace POO.Negocio
{
    internal class Beer
    {
        private int _stock;
        private decimal _alcohol;
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Alcohol
        {
            get { return _alcohol; }
            set
            {
                if (value < 0)
                {
                    _alcohol = 0;
                    return;
                }
                _alcohol = value;
            }
        }
        public int Stock
        {
            get => _stock;
            set => _stock = value < 0 ? 10 : value;
        }

        public Beer(string nombre, decimal precio, decimal alcohol, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Alcohol = alcohol;
            Stock = stock;
        }

        public virtual string GetInfo()
        {
            return "Nombre: " + Nombre + " | Precio: $" + Precio + " | Grados: " + Alcohol + "% | Cantidad: " + Stock;
        }

        public string GetInfo(int number)
        {
            return number + " => " + GetInfo();

        }
    }
}
