public abstract class Shape
{
    protected IDrawImplementation drawImplementation;

    protected Shape(IDrawImplementation drawImplementation)
    {
        this.drawImplementation = drawImplementation;
    }

    public abstract void Draw(int x, int y);
    public abstract string GetShapeInfo();

}
