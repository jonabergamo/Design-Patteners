public class ComputerScreen : IDrawImplementation
{
    public void DrawCircle(int radius, int x, int y)
    {
        Console.WriteLine($"Drawing a circle on computer screen with radius {radius} at ({x}, {y})");
    }

    public void DrawRectangle(int width, int height, int x, int y)
    {
        Console.WriteLine($"Drawing a rectangle on computer screen with width {width} and height {height} at ({x}, {y})");
    }
}
