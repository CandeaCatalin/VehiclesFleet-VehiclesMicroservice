using FluentValidation;
using VehiclesMicroservice.Domain.Validators;

namespace VehiclesMicroservice.Domain.Dtos;

public class RemoveVehicleDto
{
    public static RemoveVehicleDtoValidator Validator => new();
    public string VehicleId { get; set; }
    
    public async Task ValidateAndThrow()
    {
        await Validator.ValidateAndThrowAsync(this);
    }
}