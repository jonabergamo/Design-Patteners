public class Circle : Shape
{
    private int radius, width, height;

    public Circle(int radius, int width, int height, IDrawImplementation drawImplementation) : base(drawImplementation)
    {
        this.radius = radius;
        this.width = width;
        this.height = height;
    }

    public override void Draw(int x, int y)
    {
        drawImplementation.Draw(this, x, y);
    }

    public override string GetShapeInfo()
    {
        return $"circulo com largura {width}, altura {height} e raio {radius}";
    }
}
