using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class CnpjConverter : ValueConverter<Cnpj, string>
{
    public CnpjConverter() : base(
        dbValue => dbValue,
        value => new Cnpj(value))
    {

    }
}