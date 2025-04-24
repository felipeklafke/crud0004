using Crud.Applications.Models;
using Crud.Applications.Notifications;
using Microsoft.EntityFrameworkCore;

namespace Crud.Applications;



public interface IPlatformApplication
{
    DbSet<Deliverer> Deliverers { get; }
    DbSet<Motorcycle> Motorcycles { get; }

    void RegisterMotorcycle(Motorcycle motor);
    void RegisterNewEvent(INotificationEvent notificationEvent);


}