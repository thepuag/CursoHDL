using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Negocio
{
    public class Elementos<T>
    {
        private int _indice;
        private T[] _elementos;
        private int _limite;

        public Elementos(int limite)
        {
            _indice = 0;
            _limite = limite;
            _elementos = new T[_limite];
        }

        public void Add(T elemento)
        {
            if (_indice < _limite) 
            {
                _elementos[_indice] = elemento;
                _indice++;
            }

        }

        public void Get()
        {
            foreach (var elemento in _elementos)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
