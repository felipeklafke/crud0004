namespace Crud.Applications.Notifications;



public class FelipeNotificationSubscription : NotificationSubscription
{
    public FelipeNotificationSubscription(INotificationEvent interest, INotificationSubscriber subscriber) : base(interest, subscriber)
    {
    }
}