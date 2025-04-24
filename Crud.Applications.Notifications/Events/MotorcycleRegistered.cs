namespace Crud.Applications.Notifications;


public readonly record struct MotorcycleRegistered(string Texto) : INotificationEvent
{

}