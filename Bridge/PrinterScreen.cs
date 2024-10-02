public class PrinterScreen : IDrawImplementation
{
    public void Draw(Shape shape, int x, int y)
    {
        Console.WriteLine($"Exibindo um {shape.GetShapeInfo()} na tela da impressora em ({x}, {y})");
    }
}
