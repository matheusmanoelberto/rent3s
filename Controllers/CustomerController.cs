using Microsoft.AspNetCore.Mvc;

using rent3s.Domain.Customer;

[Route("api/Customer")]
public class CustomerController : ControllerBase
{
    [HttpGet]  
    public IActionResult Index()
    {
        var list = new List<CustomerList>();

        for (int i = 0; i < 5; i++)
            list.Add(new CustomerList()
            {
                Email = $"email{i}@gmail.com",
                Nome = $"MEU CLIENTE {i}"
            });

        return list.Any() 
        ? Ok(list) 
        : NoContent();
    }

    [HttpPost] 
    public IActionResult Store([FromBody] CustomerItem request)
    {
        return Created("", request);
    }

    [HttpPut("{id:int}")] 
    public IActionResult Update([FromBody] CustomerItem request, int id)
    {
        return Ok();
    }

    [HttpDelete("{id:int}")] 
    public IActionResult Delete()
    {
        return Ok();
    }
}