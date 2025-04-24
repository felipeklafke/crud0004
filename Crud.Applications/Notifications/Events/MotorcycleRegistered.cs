namespace Crud.Applications.Notifications;


public readonly record struct MotorcycleRegistered : INotificationEvent
{
    public void Execute()
    {
        Console.WriteLine("motocycle");
    }
}