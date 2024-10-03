public class Archipelago
{
    private Dictionary<string, List<IObserver>> observersByEvent = new Dictionary<string, List<IObserver>>();
    private string archipelagoName;
    private Dictionary<string, string> happenings = new Dictionary<string, string>();

    public Archipelago(string archipelagoName)
    {
        this.archipelagoName = archipelagoName;
    }

    public string GetHappening(string eventType)
    {
        return happenings.ContainsKey(eventType) ? happenings[eventType] : "No event happening";
    }

    public void SetHappening(string eventType, string happening)
    {
        // Se o evento não existir ainda, cria a chave no dicionário de happenings, mas NÃO sobrescreve a lista de observadores
        if (!happenings.ContainsKey(eventType))
        {
            happenings[eventType] = happening;
        }
        else
        {
            happenings[eventType] = happening;
        }

        Console.WriteLine($"Evento '{eventType}' ocorreu: {happening}");
        NotifyObservers(eventType);
    }

    public void RegisterObserver(string eventType, IObserver observer)
    {
        if (!observersByEvent.ContainsKey(eventType))
        {
            observersByEvent[eventType] = new List<IObserver>();
        }

        if (!observersByEvent[eventType].Contains(observer))
        {
            observersByEvent[eventType].Add(observer);
            Console.WriteLine($"{observer.GetObserverName()} se inscreveu para o evento '{eventType}'");
        }
    }

    public void RemoveObserver(string eventType, IObserver observer)
    {
        if (observersByEvent.ContainsKey(eventType))
        {
            observersByEvent[eventType].Remove(observer);
        }
    }

    public void NotifyObservers(string eventType)
    {
        if (observersByEvent.ContainsKey(eventType))
        {
            if (observersByEvent[eventType].Count > 0)
            {
                foreach (var observer in observersByEvent[eventType])
                {
                    observer.Update(eventType, happenings[eventType]);
                }
            }
            else
            {
                Console.WriteLine($"Nenhum observador registrado para o evento '{eventType}'.");
            }
        }
        else
        {
            Console.WriteLine($"Evento '{eventType}' não possui observadores registrados.");
        }
    }
}
