using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class DateOfBirthConverter : ValueConverter<DateOfBirth, DateOnly>
{
    public DateOfBirthConverter() : base(
        dbValue => DateOnly.ParseExact(dbValue.ToString(), "yyyy-MM-dd"),
        value => new DateOfBirth(value))
    {

    }

}