namespace Crud.Applications.Notifications;



public sealed class NotificationSubscriptionMotorcycleRegistered : NotificationSubscription, INotificationSubscription
{

    public INotificationEvent Interest { get; set; }
    public INotificationSubscriber Subscriber { get; set; }


    public NotificationSubscriptionMotorcycleRegistered(INotificationEvent interest, INotificationSubscriber subscriber) : base(interest, subscriber)
    {
    }
}