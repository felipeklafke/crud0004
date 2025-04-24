namespace Crud.Applications.Notifications;



public class PlatformNotificationSubscription : NotificationSubscription
{
    public PlatformNotificationSubscription(INotificationEvent interest, INotificationSubscriber subscriber) : base(interest, subscriber)
    {
    }
}