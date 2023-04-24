
using rent3s.Domain.Enums;

namespace rent3s.Domain.Vehicle;  

public class VehicleList : Shared.ItemBase{
    public string? Nome { get; set; }
    public int Capacity { get; set; }
    public int Doors { get; set; }
    public string? Image { get; set; }
    public decimal Price { get; set; }
    public eTrasmissionType transmissionType { get; set; }
    public eCategoryVehicle Category {get; set; }
}