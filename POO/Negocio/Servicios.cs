using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Negocio
{
    public class Servicios: IVendible
    {
        private decimal _precio;
        private decimal _impuestos;

        public Servicios(decimal precio, decimal impuestos)
        {
            _precio = precio;
            _impuestos = impuestos;
        }

        public decimal GetPrecio()
        {
            return _precio + _impuestos;
        }
    }
}
