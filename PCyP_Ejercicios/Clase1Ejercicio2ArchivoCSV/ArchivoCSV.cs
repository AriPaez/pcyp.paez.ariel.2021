using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicio2ArchivoCSV
{

    

    class ArchivoCSV
    {
        private string[] lineas;

        public ArchivoCSV() { }

        public string[] lecturaArchivo()
        {
            lineas = File.ReadAllLines(@"C: \Users\ArielPaez\Desktop\APU_8\03ProgramacionParalela\desarrollo\pcyp.paez.ariel.2021\PCyP_Ejercicios\Clase1Ejercicio2ArchivoCSV\vial.csv");

            return lineas;
        }


        public void imprimir()
        {
 

            foreach(var i in lecturaArchivo())
            {
                var linea = i.Split(',');

                Console.WriteLine($"{linea[0]}{"  "}{linea[1]}{"  "}{linea[2]}{"  "}{linea[3]}{"  "}{linea[4]}");
            }

        }

    }



}
