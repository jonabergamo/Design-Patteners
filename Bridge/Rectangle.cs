public class Rectangle : Shape
{
    private int width, height;

    public Rectangle(int width, int height, IDrawImplementation drawImplementation)
        : base(drawImplementation)
    {
        this.width = width;
        this.height = height;
    }

    public override void Draw(int x, int y)
    {
        drawImplementation.Draw(this, x, y);
    }

    public override string GetShapeInfo()
    {
        return $"retângulo com largura {width} e altura {height}";
    }
}
