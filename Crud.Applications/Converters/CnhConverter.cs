using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class CnhConverter : ValueConverter<Cnh, string>
{
    public CnhConverter() : base(
        dbValue => dbValue,
        value => new Cnh(value))
    {

    }
}