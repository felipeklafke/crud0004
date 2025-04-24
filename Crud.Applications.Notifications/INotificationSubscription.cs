namespace Crud.Applications.Notifications;



public interface INotificationSubscription
{
    INotificationEvent Interest { get; set; }
    INotificationSubscriber Subscriber { get; set; }
}