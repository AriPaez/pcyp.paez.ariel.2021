using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Abecedario
{
    class Program
    {
        static void Main(string[] args)
        {

            Alphabet abc = new Alphabet();

            Task taskA = Task.Factory.StartNew(abc.alphabetA);
            
            Task taskB = Task.Factory.StartNew(abc.alphabetB);

            var tasks = new Task[]{taskA,taskB};

            Task.WaitAll(tasks);

            Console.ReadLine();

        }
    }
}
