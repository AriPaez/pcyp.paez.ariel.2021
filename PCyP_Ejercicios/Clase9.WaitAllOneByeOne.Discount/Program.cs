using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9.WaitAllOneByeOne.Discount
{
    class Program
    {
        public static double discount(double number)
        {
            return number *= 0.7;

        }

        /// <summary>
        /// Apply discount of 30 % to three products and add the results
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {

            double priceProduct1 = 350.99;
            double priceProduct2 = 650.99;
            double priceProduct3 = 550.99;



            Task<double> discount1 = Task.Factory.StartNew((price) => {

                return discount((double)price);

            }, priceProduct1);

            Task<double> discount2 = Task.Factory.StartNew((price) => {

                return discount((double)price);

            }, priceProduct2);

            Task<double> discount3 = Task.Factory.StartNew((price) => {

                return discount((double)price);

            }, priceProduct3);


            List<Task<double>> tasks = new List<Task<double>>()
            {
                discount1, discount1, discount1
            };





            double total = 0;
            int index;
            while (tasks.Count > 0)
            {

                index = Task.WaitAny(tasks.ToArray());

                Console.WriteLine(index);
                total += tasks[index].Result;

                tasks.RemoveAt(index);

            }


            Console.WriteLine($"The total value is :{total} ");
            Console.ReadLine();
        }
    }
}
