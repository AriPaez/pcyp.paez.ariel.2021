using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Ejercicio1DiccionarioBasico
{
    class Diccionario
    {

        Dictionary<string, string> values = new Dictionary<string, string>();

        public Diccionario()
        {

            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

        }

        
        public void buscarLLave(string nombre)
        {
            if (values.ContainsKey(nombre))
            {
                Console.WriteLine(values[nombre]);
            }
            else
            {
                Console.WriteLine("No existe Llave");
            }
        }
        
 
        public string obtenerLlave(string nombre)
        {

            string valor="";

            if (values.TryGetValue(nombre, out valor))
            {
                return valor;
            }
            else
            {
               return "No contiene la llave";
            }
        }
         

        public void imprmir()
        {
             
            foreach (var iterador in values)
            {
                 
                Console.WriteLine(iterador.Key +","+iterador.Value);
                
              
            }

        }

        public void alterarValor(string indice, string valor)
        {
            if (values.ContainsKey(indice))
            {
                values[indice] = valor;
                Console.WriteLine("Nuevo telefono de {0} es {1}",indice,valor);
            }
            else
            {
                Console.WriteLine("No existe indice!!!");
            }
        }



    }
}
