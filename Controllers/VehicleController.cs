using Microsoft.AspNetCore.Mvc;

using rent3s.Domain.Vehicle;

[Route("api/Vehicle")]
public class VehicleController : ControllerBase
{
    [HttpGet]  
    public IActionResult Index()
    {
        var list = new List<VehicleList>();

        for (int i = 0; i < 5; i++)
            list.Add(new VehicleList()
            {
                Nome = $"Fiat Mobi{i}",
                Capacity = 5,
                Category = rent3s.Domain.Enums.eCategoryVehicle.Small,
                Doors = 4,
                Image ="https://production.autoforce.com/uploads/version/profile_image/2057/comprar-like-1-0-flex-4p_c612720b87.png",
                Price = 80,
                Id = i,
                transmissionType = rent3s.Domain.Enums.eTrasmissionType.Manual,
                
            });

        return list.Any() 
        ? Ok(list) 
        : NoContent();
    }

    [HttpPost] 
    public IActionResult Store([FromBody] VehicleItem request)
    {
        return Created("", request);
    }

    [HttpPut("{id:int}")] 
    public IActionResult Update([FromBody] VehicleItem request, int id)
    {
        return Ok();
    }

    [HttpDelete("{id:int}")] 
    public IActionResult Delete()
    {
        return Ok();
    }
}