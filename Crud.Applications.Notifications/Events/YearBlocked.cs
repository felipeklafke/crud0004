namespace Crud.Applications.Notifications;


public readonly record struct YearBlocked(short Ano) : INotificationEvent
{

}