using System;

// Clase abstracta FiguraGeometrica
public abstract class FiguraGeometrica
{
    // Nombre ahora es protected
    protected string Nombre { get; set; }

    public FiguraGeometrica(string nombre)
    {
        this.Nombre = nombre;
        Console.WriteLine($"Constructor de {nombre}");
    }

    // Métodos abstractos
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();

    // Destructor virtual
    ~FiguraGeometrica()
    {
        Console.WriteLine($"Destructor de {Nombre}");
    }

    // Método para obtener el nombre (ya que Nombre es protected)
    public string ObtenerNombre()
    {
        return Nombre;
    }
}