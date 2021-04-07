using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Ejercicio2ManejoListas
{
    class ManejoListas
    {

        private List<string> colores;
        private List<string> quitarColores;
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };


        public ManejoListas()
        {
            colores = new List<string>();
            quitarColores = new List<string>();
        }

        public void cargarColores()
        {
            foreach (string i in colors)
            {
                colores.Add(i);
            }

        }

        public void cargarColoresARemover()
        {
            foreach (string i in removeColors)
            {
                quitarColores.Add(i);
            }
        }


        public void imprimir()
        {

            foreach (string i in colores)
            {
                Console.Write($"{i} ");

            }

        }

        public void remueveColores()
        {
            for (int i = 0; i < quitarColores.Count; i++)
            {
                for (int j = 0; j < colores.Count; j++)
                {

                    if (colores[j] == quitarColores[i])
                    {
                        colores.RemoveAt(j);
                    }

                }
            }
        }

        public void existeColor(string unColor)
        {
            bool existe = false;

            for (int i = 0; i < colores.Count && !existe; i++)
            {
                if (colores[i].Equals(unColor))
                {
                    Console.WriteLine($"La lista contiene {unColor} en indice {i}");
                    existe = true;
                }
            }

            if (!existe)
            {
                Console.WriteLine($"La lista no contiene {unColor}");
            }
        }

        public int tamanioListColores() => colores.Count;

        public int capacidadTotal() => colores.Count + quitarColores.Count;


    }
}
