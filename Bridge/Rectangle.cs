public class Rectangle : Shape
{
    private int width, height, x, y;

    public Rectangle(int width, int height, int x, int y, IDrawImplementation drawImplementation) : base(drawImplementation)
    {
        this.width = width;
        this.height = height;
        this.x = x;
        this.y = y;
    }

    public override void Draw()
    {
        drawImplementation.DrawRectangle(width, height, x, y);
    }
}
