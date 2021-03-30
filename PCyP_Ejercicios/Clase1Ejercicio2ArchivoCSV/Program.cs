using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicio2ArchivoCSV
{
    /// <summary>
    /// Recorrer el archivo vial.csv, tomar cada linea, separar los campos y mostrarlos por pantalla. 
   /// Instanciar un objeto por cada linea  que pueda registrar los campos necesarios y que exponga un método imprimir() 
   /// donde muestre esos valores.
   // Los campos del archivo CSV son: número-de-hoja, tipo-objeto, identificador-tramo, tipo-camino, 
   /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            ArchivoCSV a = new ArchivoCSV();

            a.imprimir();
        }
    }
}
