namespace Crud.Applications.Models;

public record struct DateOfFinalLocation(DateOnly Date)
{
    public static implicit operator DateOfFinalLocation(DateOnly dateOfFinalLocation)
    {
        return new DateOfFinalLocation(dateOfFinalLocation);
    }

    public static implicit operator DateOnly(DateOfFinalLocation dateOfFinalLocation)
    {
        return dateOfFinalLocation.Date;
    }

}
