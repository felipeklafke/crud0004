namespace Crud.Applications.Notifications;




public abstract class NotificationSubscription : INotificationSubscription
{

    public INotificationEvent Interest { get; set; }
    public INotificationSubscriber Subscriber { get; set; }

    public NotificationSubscription(INotificationEvent interest, INotificationSubscriber subscriber)
    {
        Interest = interest;
        Subscriber = subscriber;
    }

}
