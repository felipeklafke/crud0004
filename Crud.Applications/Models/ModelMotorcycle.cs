namespace Crud.Applications.Models;

public record struct ModelMotorcycle(string Identificador)
{
    public static implicit operator ModelMotorcycle(string modelMotorcycle)
    {
        return new ModelMotorcycle(modelMotorcycle);
    }

    public static implicit operator string(ModelMotorcycle modelMotorcycle)
    {
        return modelMotorcycle.Identificador;
    }
}
