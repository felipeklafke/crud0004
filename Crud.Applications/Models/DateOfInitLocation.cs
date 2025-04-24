namespace Crud.Applications.Models;

public record struct DateOfInitLocation(DateOnly Date)
{
    public static implicit operator DateOfInitLocation(DateOnly dateOfInitLocation)
    {
        return new DateOfInitLocation(dateOfInitLocation);
    }

    public static implicit operator DateOnly(DateOfInitLocation dateOfInitLocation)
    {
        return dateOfInitLocation.Date;
    }

}
