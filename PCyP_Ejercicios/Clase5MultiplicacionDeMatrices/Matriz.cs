using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5MultiplicacionDeMatrices
{
    class Matriz
    {

        private int[,] matriz;
        private int filas, columnas;

        public Matriz(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;

            matriz = new int[filas, columnas];
        }


        public void cargarMatriz()
        {
            Console.WriteLine("Ingrese valores en la Matriz\n");

            try
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }

                }

            }
            catch (System.FormatException e)
            {
                throw;

            }

        }


        public void imprimirMatriz()
        {
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]}  ");
                }

            }

        }


        public static void producto(Matriz matrizA, Matriz matrizB)
        {
            int suma = 0;


            if (matrizA.getColumnas() != matrizB.getFilas())
            {
                Console.WriteLine("No se puede realizar la multiplicacion!");
                return;
            }



            Matriz matrizMultiplicacion = new Matriz(matrizA.getFilas(), matrizB.getColumnas());

            for (int i = 0; i < matrizA.getFilas(); i++)
            {

                for (int j = 0; j < matrizB.getColumnas(); j++)
                {
                    suma = 0;
                    for (int k = 0; k < matrizA.getColumnas(); k++)
                    {
                        suma += matrizA.getMatriz()[i, k] * matrizB.getMatriz()[k, j];
                    }

                    matrizMultiplicacion.getMatriz()[i, j] = suma;
                }
            }

            Console.WriteLine("--MatrizA--");
            matrizA.imprimirMatriz();
            Console.WriteLine("\n--MatrizB--");
            matrizB.imprimirMatriz();
            Console.WriteLine("\n--Producto de MatrizA y MatrizB--");
            matrizMultiplicacion.imprimirMatriz();

            Console.ReadLine();

        }


        public int getFilas() => this.filas;
        public int getColumnas() => this.columnas;
        public int[,] getMatriz() => this.matriz;

    }
}
