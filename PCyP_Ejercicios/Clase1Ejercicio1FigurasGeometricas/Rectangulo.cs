using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicio1FigurasGeometricas
{
    class Rectangulo : Figura
    {
        public Rectangulo(double altura, double baseFigura) : base(altura, baseFigura)
        {
        }

        public override double calcularArea() => this.altura * this.baseFigura;

        public override double calcularPerimetro() => (this.altura * 2) + (this.baseFigura * 2);


    }


}
