using Microsoft.AspNetCore.Mvc;

using rent3s.Domain.Locations;

using rent3s.Domain.Interfaces;

using System.Data;

// https://localhost:7259/api/locations
//HTTP VERBS - (GET, POST, PUT, DELETE)
//HTTP Codes - (1xx, 2xx 4xx, 5xx)

[Route("api/locations")]
public class LocationController : ControllerBase
{
    private readonly ILocationRepository _repository;
    public LocationController(ILocationRepository repository)
    {
        _repository = repository;
    }

    [HttpGet] // Leitura (Listagem das localizações) 
    public IActionResult Index([FromQuery] int page = 0, int per_page =10)
    {
        var res = _repository.GetLocations(page, per_page);

        var list = new List<LocationList>();
        foreach (DataRowView item in res)
            list.Add(new LocationList()
            {
                Nome = $"{item["name"]}",
                Id = (int)item["id"]
            });

        return list.Any()
            ? Ok(list)
            : NoContent();
    }

    [HttpPost] // Criaçao -(Criar Localizaçao)
    public IActionResult Store([FromBody] LocationItem request)
    {
        return Created("", request);
    }

    [HttpPut("{id:int}")] // UPDATE
    public IActionResult Update([FromBody] LocationItem request, int id)
    {
        return Ok();
    }

    [HttpDelete("{id:int}")] // DELETE
    public IActionResult Delete()
    {
        return Ok();
    }
}