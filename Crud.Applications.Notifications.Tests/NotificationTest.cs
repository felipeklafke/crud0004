namespace Crud.Applications.Notifications.Tests;

public class NotificationTest
{
    [Fact]
    public void SubscriptionsTest()
    {
        var subscriberA = new PlatformNotificationSubscriber();
        var subscriberB = new FelipeNotificationSubscriber();

        var subscriptionA = new PlatformNotificationSubscription(new MotorcycleRegistered(), subscriberA);
        var subscriptionB = new PlatformNotificationSubscription(new YearBlocked(), subscriberA);

        var subscriptionC = new FelipeNotificationSubscription(new MotorcycleRegistered(), subscriberB);
        var subscriptionD = new PlatformNotificationSubscription(new MotorcycleRegistered(), subscriberB);


        PlatformNotificationPublisher pub = new();
        pub.Register(subscriptionA);
        pub.Register(subscriptionA);
        pub.Register(subscriptionB);
        pub.Register(subscriptionC);
        pub.Register(subscriptionD);

        pub.NotifySubscriptions(new MotorcycleRegistered("meu texto"));
        pub.NotifySubscriptions(new MotorcycleRegistered("messu sad"));
        pub.NotifySubscriptions(new MotorcycleRegistered("mesasu as"));
        pub.NotifySubscriptions(new MotorcycleRegistered("measau assa"));

        pub.NotifySubscriptions(new YearBlocked(2022));

        Assert.NotEmpty(pub.Subscriptions);
        Assert.True(pub.Subscriptions.Contains(subscriptionA));
        Assert.True(pub.Subscriptions.Contains(subscriptionB));


    }
}