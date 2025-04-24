namespace Crud.Applications.Models;

public record struct PlateMotorcycle(string Identifier)
{
    public static implicit operator PlateMotorcycle(string plateMotorcycle)
    {
        return new PlateMotorcycle(plateMotorcycle);
    }

    public static implicit operator string(PlateMotorcycle plateMotorcycle)
    {
        return plateMotorcycle.Identifier;
    }
}
