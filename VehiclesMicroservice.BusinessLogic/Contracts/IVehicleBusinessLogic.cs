using VehiclesMicroservice.Domain.Dtos;
using VehiclesMicroservice.Domain.Models;

namespace VehiclesMicroservice.BusinessLogic.Contracts;

public interface IVehicleBusinessLogic
{
    Task AddVehicle(AddVehicleDto dto,string? token);
    Task EditVehicle(EditVehicleDto dto,string? token);
    Task<IList<Vehicle>> GetVehicles(bool allVehicles);
    Task<IList<VehicleError>> GetVehicleErrors(GetVehicleErrorsDto dto);
    Task FixErrorForVehicle(FixErrorForVehicleDto dto, string? token);
    Task ChangeUserToVehicle(ChangeUserDto dto,string? token);
    Task AddErrorsToVehicle(AddErrorsToVehicleDto dto,string? token);
    Task RemoveVehicle(RemoveVehicleDto dto,string? token);
}