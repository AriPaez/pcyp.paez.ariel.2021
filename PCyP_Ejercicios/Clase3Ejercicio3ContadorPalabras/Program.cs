using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Ejercicio3ContadorPalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un parrafo");

            ContadorDePalabras cP = new ContadorDePalabras();

            string parrafo = Console.ReadLine();

            

            cP.ingresarParrafo(parrafo);
            cP.imprimir();

        }
    }
}
