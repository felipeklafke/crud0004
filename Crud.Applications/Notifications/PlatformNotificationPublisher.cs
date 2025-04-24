
using System.Runtime.CompilerServices;

namespace Crud.Applications.Notifications;

public sealed class PlatformNotificationPublisher : INotificationPublisher
{
    public IList<INotificationSubscription> Subscriptions { get; set; } = [];

    public void NotifyAll(INotificationEvent notificationEvent)
    {
        foreach (var subscription in this.Subscriptions)
        {
            if (subscription.Interest.GetType() == notificationEvent.GetType())
            {
                subscription.Subscriber.Execute(notificationEvent);
            }
        }
    }

    public void Register(INotificationSubscription notificationSubscription)
    {
        if (!this.Subscriptions.Any(a => a.Interest.GetType() == notificationSubscription.Interest.GetType() && a.Subscriber.GetType() == notificationSubscription.Subscriber.GetType()))
            this.Subscriptions.Add(notificationSubscription);
    }

    public void Unregister(INotificationSubscription notificationSubscriber)
    {
        this.Subscriptions.Remove(notificationSubscriber);
    }
}


// public class Teste
// {

//     void Testezin()
//     {

//         PlatformNotificationPublisher pub = new PlatformNotificationPublisher();

//         var subs = new NotificationSubscriptionMotorcycleRegistered();

//         pub.Register(subs);

//         pub.NotifyAll(new MotorcycleRegistered());
//     }

// }