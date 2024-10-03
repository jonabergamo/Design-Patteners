public class Resident : IObserver
{
    private string residentName;

    public Resident(string name)
    {
        this.residentName = name;
    }


    public void Update(string eventType, string happening)
    {
        Console.WriteLine($"Notificação para {residentName} a respeito do evento de {eventType.ToLower()}: {happening}");
    }

    public string GetObserverName()
    {
        return residentName;
    }
}