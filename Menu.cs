using FigurasGeometricas;

public class Menu
{
    List<Opcion> opciones;
    List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();

    public Menu()
    {
        opciones = new List<Opcion>() {
                new Opcion("Crear Círculo", CrearCirculo),
                new Opcion("Crear Rectángulo", CrearRectangulo),
                new Opcion("Crear Triángulo", CrearTriangulo),
                new Opcion("Mostrar Figuras", MostrarFiguras),
                new Opcion("Salir", () => Environment.Exit(0))
            };

        while (true)
        {
            MostrarMenu();
            SeleccionarOpcion();
        }
    }

    public void MostrarMenu()
    {
        Console.WriteLine("Seleccione una opción:");
        for (int i = 0; i < opciones.Count; i++)
        {
            Console.WriteLine($"{i}. {opciones[i].Message}");
        }
    }

    public void SeleccionarOpcion()
    {
        if (int.TryParse(Console.ReadLine(), out int numOpcion) && numOpcion >= 0 && numOpcion < opciones.Count)
        {
            Console.Clear();
            opciones[numOpcion].Action.Invoke();
        }
        else
        {
            Console.WriteLine("Opción inválida. Intente de nuevo.");
        }
    }

    private void CrearCirculo()
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());
        figuras.Add(new Circulo(radio));
    }

    private void CrearRectangulo()
    {
        Console.WriteLine("Ingrese el largo del rectángulo:");
        double largo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el ancho del rectángulo:");
        double ancho = Convert.ToDouble(Console.ReadLine());
        figuras.Add(new Rectangulo(largo, ancho));
    }

    private void CrearTriangulo()
    {
        Console.WriteLine("Ingrese el lado 1 del triángulo:");
        double lado1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el lado 2 del triángulo:");
        double lado2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el lado 3 del triángulo:");
        double lado3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la base del triángulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triángulo:");
        double altura = Convert.ToDouble(Console.ReadLine());
        figuras.Add(new Triangulo(lado1, lado2, lado3, baseTriangulo, altura));
    }

    private void MostrarFiguras()
    {
        foreach (var figura in figuras)
        {
            Console.WriteLine($"Figura: {figura.ObtenerNombre()}");
            Console.WriteLine($"Área: {figura.CalcularArea()}");
            Console.WriteLine($"Perímetro: {figura.CalcularPerimetro()}");
            Console.WriteLine();
        }
    }
}

