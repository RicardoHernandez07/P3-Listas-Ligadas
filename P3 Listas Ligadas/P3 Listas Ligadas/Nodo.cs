using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Listas_Ligadas
{
    public class Nodo
    {
        private string dato;
        private Nodo siguiente;

        public string Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }

        public Nodo()
        {
            siguiente = null;
        }
    }
}
