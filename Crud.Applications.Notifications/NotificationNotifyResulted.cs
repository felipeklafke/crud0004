namespace Crud.Applications.Notifications;

public record class NotificationNotifyResulted(bool ExecutedError = false, string MessageError = "");