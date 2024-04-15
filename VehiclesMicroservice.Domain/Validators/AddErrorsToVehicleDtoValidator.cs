using FluentValidation;
using VehiclesMicroservice.Domain.Dtos;

namespace VehiclesMicroservice.Domain.Validators;

public class AddErrorsToVehicleDtoValidator:AbstractValidator<AddErrorsToVehicleDto>
{
    public AddErrorsToVehicleDtoValidator()
    {
        RuleFor(v => v.VehicleId).NotEmpty().WithMessage("Error list must contain valid errors");
    }
}