
namespace Crud.Applications.Models;

public record struct DateOfBirth(DateOnly Date)
{
    public static implicit operator DateOfBirth(string date)
    {
        //parrse.....
        return new DateOfBirth(DateOnly.ParseExact(date, "yyyy-MM-dd"));
    }

    public static implicit operator DateOnly(DateOfBirth cnh)
    {
        return cnh.Date;
    }
}
