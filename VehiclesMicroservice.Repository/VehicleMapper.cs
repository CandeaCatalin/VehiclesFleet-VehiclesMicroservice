using VehiclesMicroservice.DataAccess.Entities;
using VehiclesMicroservice.Repository.Contracts;
namespace VehiclesMicroservice.Repository;

public class VehicleMapper:IVehicleMapper
{
    public Vehicle DomainToDataAccess(Domain.Models.Vehicle domainVehicle)
    {
        return new Vehicle
        {
            Id = Guid.NewGuid(),
            Type = domainVehicle.Type,
            Model = domainVehicle.Model,
            TotalKilometers = domainVehicle.TotalKilometers,
            Brand = domainVehicle.Brand,
            Color = domainVehicle.Color,
            Status = domainVehicle.Status,
            PRTExpirationDate = domainVehicle.PRTExpirationDate,
            Year = domainVehicle.Year,
            Errors = new List<VehicleError>()
        };
    }

    public Domain.Models.Vehicle DataAccessToDomain(Vehicle dataAccessVehicle)
    {
        return new Domain.Models.Vehicle
        {
            Id = dataAccessVehicle.Id,
            UserId = dataAccessVehicle.UserId.ToString(),
            Type = dataAccessVehicle.Type,
            Model = dataAccessVehicle.Model,
            TotalKilometers = dataAccessVehicle.TotalKilometers,
            Brand = dataAccessVehicle.Brand,
            Color = dataAccessVehicle.Color,
            Status = dataAccessVehicle.Status,
            PRTExpirationDate = dataAccessVehicle.PRTExpirationDate,
            Year = dataAccessVehicle.Year,
        };
    }

    public Domain.Models.VehicleError ErrorDataAccessToDomain(VehicleError dataAccessError)
    {
        return new Domain.Models.VehicleError
        {
            Id = dataAccessError.Id,
            ErrorName = dataAccessError.ErrorName,
            VehicleId = dataAccessError.VehicleId,
            CreationDate = dataAccessError.CreationDate,
            FixDate = dataAccessError.FixDate,
            IsFixed = dataAccessError.IsFixed
        };
    }
}