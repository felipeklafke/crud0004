namespace Crud.Applications.Models;



public record class EventPlatform(short Id, string Message)
{
    public static implicit operator EventPlatform(string message)
    {
        return new EventPlatform(message);
    }

    public static implicit operator string(EventPlatform message)
    {
        return message.Message;
    }
}