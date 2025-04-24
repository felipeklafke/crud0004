
namespace Crud.Applications.Models;

public record struct CnhPhotoDriverer(Uri Url)
{
    public static implicit operator CnhPhotoDriverer(string cnhPhotoDriverer)
    {
        return new CnhPhotoDriverer(new Uri(cnhPhotoDriverer));
    }

    public static implicit operator Uri(CnhPhotoDriverer cnhPhotoDriverer)
    {
        return cnhPhotoDriverer.Url;
    }
}
