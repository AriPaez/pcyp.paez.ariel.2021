using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicio1FigurasGeometricas
{
    class Triangulo:Figura 
    {
        public Triangulo(double altura, double baseFigura,double lado):base (altura,baseFigura,lado)
        {
        }


        public override double calcularArea() => (this.baseFigura*this.altura)/2;

        public override double calcularPerimetro() => (this.lado*2)+this.baseFigura;



    }
}
