//identificador, nome, cnpj, data de nascimento, número da CNHh, tipo da CNH, imagemCNH)
namespace Crud.Applications.Models;

public record class Deliverer(int Identifier, string Name, Cnpj DocumentCnpj, DateOfBirth DateOfBirth, Cnh Cnh, TypesOfCnh TypeOfCnh, CnhPhotoDriverer CnhPhotoDriverer);
