using VehiclesMicroservice.BusinessLogic.Contracts;
using VehiclesMicroservice.Domain.Dtos;
using VehiclesMicroservice.Domain.Models;
using VehiclesMicroservice.Repository.Contracts;
using VehiclesMicroservice.Services.Contracts;

namespace VehiclesMicroservice.BusinessLogic;

public class VehicleBusinessLogic:IVehicleBusinessLogic
{
    private IVehicleRepository vehicleRepository;
    private readonly ILoggerService loggerService;
    
    public VehicleBusinessLogic(IVehicleRepository vehicleRepository,ILoggerService loggerService)
    {
        this.vehicleRepository = vehicleRepository;
        this.loggerService = loggerService;
    }

    public async Task AddVehicle(AddVehicleDto dto,string? token)
    {
        await dto.ValidateAndThrow();
        var vehicle = new Vehicle
        {
            UserId = dto.UserId,
            Type = dto.Type.ToString(),
            Model = dto.Model,
            TotalKilometers = dto.TotalKilometers,
            Brand = dto.Brand,
            Color = dto.Color,
            Status = dto.Status.ToString(),
            PRTExpirationDate = dto.PRTExpirationDate,
            Year = dto.Year
        };

        var addedVehicle = await vehicleRepository.AddVehicle(vehicle);
        await loggerService.LogInfo($"Vehicle with id: {addedVehicle.Id} was added",token);
    }

    public async Task EditVehicle(EditVehicleDto dto,string? token)
    {
        await dto.ValidateAndThrow();
        
        var vehicle = new Vehicle
        {
            Id = new Guid(dto.Id),
            UserId = dto.UserId,
            Type = dto.Type.ToString(),
            Model = dto.Model,
            TotalKilometers = dto.TotalKilometers,
            Brand = dto.Brand,
            Color = dto.Color,
            Status = dto.Status.ToString(),
            PRTExpirationDate = dto.PRTExpirationDate,
            Year = dto.Year
        };
        
        var editedVehicle = await vehicleRepository.EditVehicle(vehicle);
        
        await loggerService.LogInfo( $"Vehicle with id: {editedVehicle.Id} was added", token);
    }
    
    public async Task<IList<Vehicle>> GetVehicles(bool allVehicles)
    {
        return await vehicleRepository.GetVehicles(allVehicles);
    }

    public async Task<IList<VehicleError>> GetVehicleErrors(GetVehicleErrorsDto dto)
    {
        return await vehicleRepository.GetVehicleErrors(dto.VehicleId);
    }

    public async Task FixErrorForVehicle(FixErrorForVehicleDto dto, string? token)
    {
        await vehicleRepository.FixErrorForVehicle(dto.ErrorId,dto.VehicleId);
        await loggerService.LogError($"Vehicle error with id: {dto.ErrorId} was fixed for vehicle with id: {dto.VehicleId}",token);
    }


    public async Task ChangeUserToVehicle(ChangeUserDto dto, string? token)
    {
        await vehicleRepository.ChangeUserToVehicle(new Guid(dto.UserId),new Guid(dto.VehicleId));
        await loggerService.LogInfo($"Vehicle with id: {dto.VehicleId} changed owner to user with id: {dto.UserId}", token);
    }

    public async Task AddErrorsToVehicle(AddErrorsToVehicleDto dto,string? token)
    {
        await dto.ValidateAndThrow();

        await vehicleRepository.AddErrorsToVehicle(dto.ErrorsList,new Guid(dto.VehicleId));
        
        await loggerService.LogInfo($"Errors for vehicle with id: {dto.VehicleId} were added", token);
    }

    public async Task RemoveVehicle(RemoveVehicleDto dto,string? token)
    {
        await dto.ValidateAndThrow();

        await vehicleRepository.RemoveVehicle(new Guid(dto.VehicleId));
        
        await loggerService.LogInfo($"Vehicle with id: {dto.VehicleId} was removed", token);
    }
}