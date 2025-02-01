using System;

namespace FigurasGeometricas
{
    public class Triangulo : FiguraGeometrica
    {
        private double Lado1 { get; set; }
        private double Lado2 { get; set; }
        private double Lado3 { get; set; }
        private double Base { get; set; }
        private double Altura { get; set; }

        public Triangulo(double lado1, double lado2, double lado3, double baseTriangulo, double altura) : base("Triángulo")
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
            this.Base = baseTriangulo;
            this.Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
