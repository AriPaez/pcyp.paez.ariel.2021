using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase6Abecedario
{
    class Alphabet
    {

        public Alphabet() { }


        public void alphabetA()
        {
            for(int i='A';i<='Z';i++)
            {
                Thread.Sleep(500);
                Console.WriteLine((char)i);
                
            }
        }

        public void alphabetB()
        {
            for (int i = 'A'; i <= 'Z'; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine((char)i);
               

            }

        }

    }
}
