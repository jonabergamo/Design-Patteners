public interface IObserver
{
    void Update(string eventType, string happening);

    string GetObserverName();
}