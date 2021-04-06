using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Ejercicio1DiccionarioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Diccionario dic = new Diccionario();

            dic.buscarLLave("Juan");

            Console.WriteLine(dic.obtenerLlave("pedro"));

            dic.imprmir();

            dic.alterarValor("Mariana", "58251425");

            Console.ReadLine();

        }
    }
}
