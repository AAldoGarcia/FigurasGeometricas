using System;

namespace FigurasGeometricas
{
    public class Rectangulo : FiguraGeometrica
    {
        private double Largo { get; set; }
        private double Ancho { get; set; }

        public Rectangulo(double largo, double ancho) : base("Rectángulo")
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public override double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }
    }
}
