namespace Crud.Applications.Models;

public record struct Cnh(string RegistryNumber)
{
    public static implicit operator Cnh(string cnh)
    {
        return new Cnh(cnh);
    }

    public static implicit operator string(Cnh cnh)
    {
        return cnh.RegistryNumber;
    }

}
