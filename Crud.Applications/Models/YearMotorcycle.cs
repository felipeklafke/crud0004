namespace Crud.Applications.Models;

public record struct YearMotorcycle(short Year)
{
    public static implicit operator YearMotorcycle(short year)
    {
        return new YearMotorcycle(year);
    }

    public static implicit operator short(YearMotorcycle year)
    {
        return year.Year;
    }
}
