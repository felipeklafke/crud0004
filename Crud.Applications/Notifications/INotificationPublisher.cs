namespace Crud.Applications.Notifications;



public interface INotificationPublisher
{
    IList<INotificationSubscription> Subscriptions { get; set; }


    void Register(INotificationSubscription notificationSubscriber);
    void Unregister(INotificationSubscription notificationSubscriber);
    void NotifyAll(INotificationEvent notificationEvent);

}
