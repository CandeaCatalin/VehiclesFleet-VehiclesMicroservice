using FluentValidation;
using VehiclesMicroservice.Domain.Dtos;

namespace VehiclesMicroservice.Domain.Validators;

public class RemoveVehicleDtoValidator : AbstractValidator<RemoveVehicleDto>
{
    public RemoveVehicleDtoValidator()
    {
        RuleFor(x => x.VehicleId).NotEmpty().WithMessage("Provide a correct id format!");
    }
}