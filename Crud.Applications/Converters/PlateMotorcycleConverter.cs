using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class PlateMotorcycleConverter : ValueConverter<PlateMotorcycle, string>
{
    public PlateMotorcycleConverter() : base(
        dbValue => dbValue.ToString(),
        value => new PlateMotorcycle(value))
    {

    }
}