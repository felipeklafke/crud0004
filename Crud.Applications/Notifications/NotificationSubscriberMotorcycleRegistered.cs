using Crud.Applications.Notifications;

public sealed class NotificationSubscriberMotorcycleRegistered : INotificationSubscriber
{
    public void Execute(INotificationEvent events)
    {
       
        Console.WriteLine("NotificationSubscriberMotorcycleRegistered");
    }
}
