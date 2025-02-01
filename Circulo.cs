using System;

namespace FigurasGeometricas
{
    public class Circulo : FiguraGeometrica
    {
        private double Radio { get; set; }

        public Circulo(double radio) : base("Círculo")
        {
            this.Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
