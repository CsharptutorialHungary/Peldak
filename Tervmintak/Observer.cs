namespace Tervmintak;

public class Observable : IObservable<string>
{
    private readonly List<IObserver<string>> _observers;

    public Observable()
    {
        _observers = new List<IObserver<string>>();
    }

    public IDisposable Subscribe(IObserver<string> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
        return new Unsubscriber(_observers, observer);
    }

    public void SendNotification()
    {
        foreach (var observer in _observers) 
        {
            observer.OnNext("Notification");
        }
    }


    private class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<string>> _observers;
        private readonly IObserver<string> _observer;

        public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observer.OnCompleted();
                _observers.Remove(_observer);
            }
        }
    }
}

public class Observer : IObserver<string>
{
    public void OnCompleted()
    {
        //ha több esemény nem jön jelzés
    }

    public void OnError(Exception error)
    {
        //Ha hiba van
    }

    public void OnNext(string value)
    {
        Console.WriteLine(value);
    }
}
