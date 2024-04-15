namespace VehiclesMicroservice.Domain.Dtos;

public class FixErrorForVehicleDto
{
    public Guid VehicleId { get; set; }
    public Guid ErrorId { get; set; }
}