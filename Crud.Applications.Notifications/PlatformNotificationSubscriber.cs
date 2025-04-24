namespace Crud.Applications.Notifications;


public class PlatformNotificationSubscriber : INotificationSubscriber
{
    public void Execute(INotificationEvent notificationEvent)
    {
        if (notificationEvent is MotorcycleRegistered m)
        {
            Console.WriteLine(m.Texto);
        }
    }
}