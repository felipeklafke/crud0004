using Crud.Applications.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Crud.Applications;

public sealed class AdminApplication
{

    readonly IPlatformApplication platformApplication;

    public AdminApplication(IPlatformApplication platformApplication)
    {
        this.platformApplication = platformApplication;
    }

    public void RegisterMotorcycle(Motorcycle motor)
    {
        var resultIdentifier = string.IsNullOrWhiteSpace(motor.Identifier.ToString());
        var resultModel = string.IsNullOrWhiteSpace(motor.Model.Identificador.ToString());
        var resultYear = string.IsNullOrWhiteSpace(motor.Year.ToString());
        var resultPlate = string.IsNullOrWhiteSpace(motor.Plate.ToString());


        this.platformApplication.RegisterMotorcycle(motor);
    }

    public IEnumerable<Motorcycle> GetMotorcycleByPlate(PlateMotorcycle plateMotorcycle)
    {
        return this.platformApplication.Motorcycles.Where(w => w.Plate.Identifier == plateMotorcycle.Identifier);
    }


    //Eu como usuário admin quero modificar uma moto alterando 
    // apenas sua placa que foi cadastrado indevidamente
    public void FixPlateOfMotorcycle(Motorcycle motorcycle, PlateMotorcycle newPlateMotorcycle)
    {

    }


    //Eu como usuário admin quero remover uma moto que foi 
    // cadastrado incorretamente, desde que não tenha registro de locações.
    public void RemoveMorotcycleIfHaventLocation(Motorcycle removeMotorcycle)
    {

    }


}
