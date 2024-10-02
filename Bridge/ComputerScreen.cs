public class ComputerScreen : IDrawImplementation
{
    public void Draw(Shape shape, int x, int y)
    {
        Console.WriteLine($"Desenhando um {shape.GetShapeInfo()} na tela do computador em ({x}, {y})");
    }
}