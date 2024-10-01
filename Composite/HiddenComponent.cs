public class HiddenComponent : IComponent
{
    private IComponent component;
    private bool hidden;

    public HiddenComponent(IComponent component, bool hidden)
    {
        this.component = component;
        this.hidden = hidden;
    }

    public void Display(int indent)
    {
        if (!this.hidden)
        {
            component.Display(indent);
        }
    }
}