namespace Crud.Applications.Notifications;



public interface INotificationSubscriber
{
    void Execute(INotificationEvent notificationEvent);
}