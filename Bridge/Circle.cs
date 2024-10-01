public class Circle : Shape
{
    private int radius, x, y;

    public Circle(int radius, int x, int y, IDrawImplementation drawImplementation) : base(drawImplementation)
    {
        this.radius = radius;
        this.x = x;
        this.y = y;
    }

    public override void Draw()
    {
        drawImplementation.DrawCircle(radius, x, y);
    }
}
