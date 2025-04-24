using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public class CnhPhotoDrivererConverter : ValueConverter<CnhPhotoDriverer, string>
{
    public CnhPhotoDrivererConverter() : base(
        dbValue => dbValue.ToString(),
        value => new CnhPhotoDriverer(new Uri(value.ToString())))
    {

    }
}