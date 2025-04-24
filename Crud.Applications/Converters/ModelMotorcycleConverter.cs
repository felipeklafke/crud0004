using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class ModelMotorcycleConverter : ValueConverter<YearMotorcycle, short>
{
    public ModelMotorcycleConverter() : base(
        dbValue => short.Parse(dbValue.ToString()),
        value => new YearMotorcycle(short.Parse(value.ToString())))
    {

    }
}