using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicio1FigurasGeometricas
{
    class Figura
    {
        protected double lado;
        protected double baseFigura;
        protected double altura;

        public Figura(double lado)
        {
            this.lado = lado;
        }

        public Figura(double altura,double baseFigura)
        {
            this.altura = altura;
            this.baseFigura = baseFigura;
        }

        public Figura(double altura, double baseFigura,double lado)
        {
            this.altura = altura;
            this.baseFigura = baseFigura;
            this.lado=lado;
        }


        public virtual double calcularArea() => lado * lado;

        public virtual double calcularPerimetro() => lado * 4;

    }

}
