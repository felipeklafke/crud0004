namespace Crud.Applications.Models;

public record struct Cnpj(string RegistryNumber)
{
    public static implicit operator Cnpj(string cnpj)
    {
        return new Cnpj(cnpj);
    }

    public static implicit operator string(Cnpj cnpj)
    {
        return cnpj.RegistryNumber;
    }

}