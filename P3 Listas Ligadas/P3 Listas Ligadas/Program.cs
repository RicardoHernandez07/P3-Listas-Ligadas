using System;

namespace P3_Listas_Ligadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cuatro");
            lista.AgregarNodo("Cinco");

            Console.Write(lista.RecorrerLista());


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Agregando al inicio...");
            lista.AgregarNodoInicio("Cero");
            Console.Write(lista.RecorrerLista());


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Busqueda...");
            Nodo nodo = lista.Buscar("Cuatro");

            if (nodo == null)
            {
                Console.WriteLine("Dato no encontrado...!");
            }
            else
            {
                Console.WriteLine($" Se encontró el nodo con valor {nodo.Dato}");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Eliminando...");
            lista.BorrarNodo("Cuatro");
            Console.Write(lista.RecorrerLista());


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Busqueda por indice...");
            int Indice = 3;
            Nodo nodoIndice = lista.BuscarIndice(Indice);

            if (nodoIndice == null)
            {
                Console.WriteLine("Dato no encontrado...!");
            }
            else
            {
                Console.WriteLine($" Se encontró el nodo con indice {Indice} con valor {nodoIndice.Dato}");
            }



            Console.ReadKey();
        }
    }
}
