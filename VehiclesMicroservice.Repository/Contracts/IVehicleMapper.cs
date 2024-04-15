using VehiclesMicroservice.DataAccess.Entities;

namespace VehiclesMicroservice.Repository.Contracts;

public interface IVehicleMapper
{
    Vehicle DomainToDataAccess(VehiclesMicroservice.Domain.Models.Vehicle domainVehicle);
    VehiclesMicroservice.Domain.Models.Vehicle DataAccessToDomain(Vehicle dataAccessVehicle);
    VehiclesMicroservice.Domain.Models.VehicleError ErrorDataAccessToDomain(VehicleError dataAccessError);
}