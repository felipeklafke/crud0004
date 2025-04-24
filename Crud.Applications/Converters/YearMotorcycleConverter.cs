using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class YearMotorcycleConverter : ValueConverter<YearMotorcycle, short>
{
    public YearMotorcycleConverter() : base(
        dbValue => short.Parse(dbValue.ToString()),
        value => new YearMotorcycle(short.Parse(value.ToString())))
        {

        }
}