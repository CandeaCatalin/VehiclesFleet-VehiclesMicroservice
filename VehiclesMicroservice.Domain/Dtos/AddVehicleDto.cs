using FluentValidation;
using VehiclesMicroservice.Domain.Models;
using VehiclesMicroservice.Domain.Validators;

namespace VehiclesMicroservice.Domain.Dtos;

public class AddVehicleDto
{
    public static AddVehicleDtoValidator Validator => new();
    public VehicleType Type { get; set; }
    public string UserId { get; set; }
    public string Model { get; set; }
    public int TotalKilometers { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public VehicleStatus Status { get; set; }
    public DateTime PRTExpirationDate { get; set; }
    public string Year {get;set;}
    
    public async Task ValidateAndThrow()
    {
        await Validator.ValidateAndThrowAsync(this);
    }
}