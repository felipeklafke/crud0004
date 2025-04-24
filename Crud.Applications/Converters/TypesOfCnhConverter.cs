using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class TypesOfCnhConverter : ValueConverter<TypesOfCnh, string>
{
    public TypesOfCnhConverter() : base(
        dbValue => dbValue.ToString(),
        value => Enum.Parse<TypesOfCnh>(value, true)
    )
    {

    }
}