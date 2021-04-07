using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Ejercicio3ContadorPalabras
{
    class ContadorDePalabras
    {
        private Dictionary<string, int> diccionario;
        private string parrafo="";
        private string palabra; 

        public ContadorDePalabras()
        {
             diccionario=new Dictionary<string, int>();
        }

        public void ingresarParrafo(string p)
        {
            this.parrafo = p;
        }
         
        private void cargarDiccionario()
        {
            for(int i=0;i<parrafo.Length;i++)
            {
                palabra+=parrafo[i];

                if(parrafo[i]==' ')
                {

                    int  cantidad = this.contarOcurrencia(palabra.Replace(" ", String.Empty));


                    if(!diccionario.ContainsKey(palabra))
                    {
                        diccionario.Add(palabra, cantidad);
                    }

                    palabra = "";
                }
            }
        }


        private int contarOcurrencia(string palabra)
        {
            int cantidad = 0;

            string ocurrenciaPalabra="";
            

            for(int i=0;i<parrafo.Length;i++)
            {
                ocurrenciaPalabra += parrafo[i];

                if (parrafo[i]==' ' || i==parrafo.Count()-1)
                {
                    if(ocurrenciaPalabra.Replace(" ", String.Empty).Equals(palabra))
                    {
                        cantidad++;
                    }
                    ocurrenciaPalabra = "";
                }
            }
 
            return cantidad;

        }


        public void imprimir()
        {
            cargarDiccionario();

            Console.WriteLine("Key:\tValor:");
            foreach (var i in diccionario)
            {
                Console.WriteLine($"{i.Key}\t{i.Value}");
            }

            Console.ReadLine();
        }


    }
}
