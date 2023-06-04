namespace Tervmintak.Mediator;

internal interface IMediator
{
    void Notify(object sender, string message);
    void RegisterNotifyable(INotifyable notifyable);
}

internal interface INotifyable
{
    void HandleNotification(object sender, string message);
}

internal class Mediator : IMediator
{
    private readonly List<INotifyable> _notifyables;

    public Mediator()
    {
        _notifyables = new List<INotifyable>();
    }

    public void Notify(object sender, string message)
    {
        foreach (var notifyable in _notifyables) 
        {
            notifyable.HandleNotification(sender, message);
        }
    }

    public void RegisterNotifyable(INotifyable notifyable)
    {
        _notifyables.Add(notifyable);
    }
}

internal class Component
{
    protected IMediator _mediator;

    public Component(IMediator mediator)
    {
        _mediator = mediator;
    }
}

internal class Component1 : Component
{
    public Component1(IMediator mediator) : base(mediator)
    {
        _mediator.Notify(this, "Component1 Created");
    }
}

internal class PrinterComponent : Component, INotifyable
{
    public PrinterComponent(IMediator mediator) : base(mediator)
    {
        _mediator.RegisterNotifyable(this);
    }

    public void HandleNotification(object sender, string message)
    {
        Console.WriteLine($"{sender}: {message}");
    }
}