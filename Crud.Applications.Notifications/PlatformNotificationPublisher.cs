namespace Crud.Applications.Notifications;

public sealed class PlatformNotificationPublisher : INotificationPublisher
{
    public IList<INotificationSubscription> Subscriptions { get; set; } = [];

    public void NotifySubscriptions(INotificationEvent notificationEvent)
    {
        var subs = this.Subscriptions.Where(w => w.Interest.GetType() == notificationEvent.GetType());
        foreach (var subscription in subs)
        {
            subscription.Subscriber.Execute(notificationEvent);
        }
    }

    public void Register(INotificationSubscription notificationSubscription)
    {
        if (!this.Subscriptions
            .Any(a => a.Interest.GetType() == notificationSubscription.Interest.GetType() && a.Subscriber.GetType() == notificationSubscription.Subscriber.GetType()))
        {
            this.Subscriptions.Add(notificationSubscription);
        }
    }

    public void Unregister(INotificationSubscription notificationSubscriber)
    {
        this.Subscriptions.Remove(notificationSubscriber);
    }
}

