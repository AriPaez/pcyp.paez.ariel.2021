using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicio1FigurasGeometricas
{
    class Menu
    {
        private int opcion=0;

        public Menu()
        {

            iniciarMenu();

        }


        public void iniciarMenu()  
        {
            try
            { 
               do
                {

                    
                    Console.WriteLine("Calculo de Area y Perimetro");

                    Console.WriteLine("1-Calcular area y perimetro de cuadrado");
                    Console.WriteLine("2-Calcular area y perimetro de rectangulo");
                    Console.WriteLine("3-Calcular area y perimetro de triangulo");
                    Console.WriteLine("4-Salir");

               
                     opcion = int.Parse(Console.ReadLine());
                   
                    switch (opcion)
                    {
                        case 1:

                                Console.WriteLine("Ingrese lado");
                         
                                int lado = int.Parse(Console.ReadLine());

                                Cuadrado cua = new Cuadrado(lado);

                                Console.WriteLine($"El area del cuadrado es:{cua.calcularArea()}");
                                Console.WriteLine($"El perimetro del cuadrado es:{cua.calcularPerimetro()}");

                        break;
                        case 2:

                                Console.WriteLine("Ingrese altura");
                                int altura = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese base");
                                int baseFigura = int.Parse(Console.ReadLine());

                                Rectangulo rec = new Rectangulo(altura,baseFigura);

                                Console.WriteLine($"El area del rectangulo es:{rec.calcularArea()}");
                                Console.WriteLine($"El perimetro del rectangulo es:{rec.calcularPerimetro()}");
                        break;
                        case 3:

                                Console.WriteLine("Ingrese altura");
                                altura = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese base");
                                baseFigura = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese lado");
                                lado = int.Parse(Console.ReadLine());

                                Triangulo tri = new Triangulo(altura, baseFigura, lado);

                                Console.WriteLine($"El area del rectangulo es:{tri.calcularArea()}");
                                Console.WriteLine($"El perimetro del rectangulo es:{tri.calcularPerimetro()}");
                        break;
                        case 4:
                            Console.WriteLine("Chau!!");
                         break;
                    }

                    Console.ReadLine();
                    Console.Clear();
                }
                while (opcion != 4);
              }
              catch(Exception ee)
              {
                    Console.WriteLine("Error, ingrese un valor entero.");
                    Console.ReadLine();
              }

        }
             
                
    }
}
