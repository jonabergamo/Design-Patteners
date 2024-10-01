public class PrinterScreen : IDrawImplementation
{
    public void DrawCircle(int radius, int x, int y)
    {
        Console.WriteLine($"Printing a circle with radius {radius} at ({x}, {y})");
    }

    public void DrawRectangle(int width, int height, int x, int y)
    {
        Console.WriteLine($"Printing a rectangle with width {width} and height {height} at ({x}, {y})");
    }
}
