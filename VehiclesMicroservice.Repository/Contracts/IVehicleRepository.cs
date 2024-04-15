using VehiclesMicroservice.Domain.Models;

namespace VehiclesMicroservice.Repository.Contracts;

public interface IVehicleRepository
{
    Task<VehiclesMicroservice.DataAccess.Entities.Vehicle> AddVehicle(Vehicle vehicle);
    Task<VehiclesMicroservice.DataAccess.Entities.Vehicle> EditVehicle(Vehicle vehicle);
    Task<Guid> RemoveVehicle(Guid vehicleId);
    Task<IList<Vehicle>> GetVehicles(bool allVehicles);
    Task ChangeUserToVehicle(Guid UserId, Guid VehicleId);
    Task AddErrorsToVehicle(IList<Error> errorsList,Guid VehicleId);
    Task<IList<VehicleError>> GetVehicleErrors(Guid vehicleId);
    Task FixErrorForVehicle(Guid errorId, Guid vehicleId);

}