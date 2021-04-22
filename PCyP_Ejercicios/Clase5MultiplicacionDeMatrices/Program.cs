using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5MultiplicacionDeMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;



            try
            {

                Console.WriteLine("Ingrese fila de MatrizA");
                filas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese columna de MatrizA");
                columnas = int.Parse(Console.ReadLine());
                Matriz matrizA = new Matriz(filas, columnas);


                Console.WriteLine("Ingrese fila de MatrizB");
                filas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese columna de MatrizB");
                columnas = int.Parse(Console.ReadLine());
                Matriz matrizB = new Matriz(filas, columnas);

                matrizA.cargarMatriz();
                matrizB.cargarMatriz();
                Matriz.producto(matrizA, matrizB);
            }
            catch (Exception)
            {
                Console.WriteLine("Error!Ingrese solo valores enteros.");
                Console.ReadLine();
            }



        }
    }
}
