namespace VehiclesMicroservice.Domain.Models;

public class VehicleError
{
    public Guid Id { get; set; }
    public string ErrorName { get; set; }
    public Guid VehicleId { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? FixDate { get; set; }
    public bool IsFixed { get; set; }
}