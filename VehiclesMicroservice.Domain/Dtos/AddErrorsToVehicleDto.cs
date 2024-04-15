using FluentValidation;
using VehiclesMicroservice.Domain.Models;
using VehiclesMicroservice.Domain.Validators;

namespace VehiclesMicroservice.Domain.Dtos;

public class AddErrorsToVehicleDto
{
    public static AddErrorsToVehicleDtoValidator Validator => new();

    public IList<Error> ErrorsList { get; set; }
    public string VehicleId { get; set; }

    public async Task ValidateAndThrow()
    {
        await Validator.ValidateAndThrowAsync(this);
    }
}