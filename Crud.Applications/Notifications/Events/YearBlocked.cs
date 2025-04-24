namespace Crud.Applications.Notifications;


public readonly record struct YearBlocked() : INotificationEvent
{
    public void Execute()
    {
        throw new NotImplementedException();
    }
}