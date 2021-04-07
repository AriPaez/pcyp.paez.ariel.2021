using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Ejercicio2ManejoListas
{
    class Program
    {
        static void Main(string[] args)
        {

            ManejoListas mL = new ManejoListas();

            Console.WriteLine("List:");

            mL.cargarColores();
            mL.cargarColoresARemover();
            mL.imprimir();
            Console.WriteLine($"\nTamaño:{mL.tamanioListColores()}; Capacidad:{mL.capacidadTotal()}");
            mL.existeColor("BLUE");


            mL.remueveColores();
            mL.imprimir();
            Console.WriteLine($"\nTamaño:{mL.tamanioListColores()}; Capacidad:{mL.capacidadTotal()}");
            mL.existeColor("BLUE");

            Console.ReadLine();

        }



    }
}

