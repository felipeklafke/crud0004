namespace Crud.Applications.Models;

public record struct DateOfPrevFinalLocation(DateOnly Date)
{
    public static implicit operator DateOfPrevFinalLocation(DateOnly dateOfPrevFinalLocation)
    {
        return new DateOfPrevFinalLocation(dateOfPrevFinalLocation);
    }

    public static implicit operator DateOnly(DateOfPrevFinalLocation dateOfPrevFinalLocation)
    {
        return dateOfPrevFinalLocation.Date;
    }

}
