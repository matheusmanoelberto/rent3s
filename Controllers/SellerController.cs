using Microsoft.AspNetCore.Mvc;

using rent3s.Domain.Seller;

[Route("api/seller")]
public class SellerController : ControllerBase
{
    [HttpGet]  
    public IActionResult Index()
    {
        var list = new List<SellerList>();

        for (int i = 0; i < 5; i++)
            list.Add(new SellerList()
            {
                Active = true,
                Email = $"email{i}@gmail.com",
                Nome = $"MINHA LOJA {i}",
                Image = "",
                Id = i
            });

        return list.Any() 
        ? Ok(list) 
        : NoContent();
    }

    [HttpPost] 
    public IActionResult Store([FromBody] SellerItem request)
    {
        return Created("", request);
    }

    [HttpPut("{id:int}")] 
    public IActionResult Update([FromBody] SellerItem request, int id)
    {
        return Ok();
    }

    [HttpDelete("{id:int}")] 
    public IActionResult Delete()
    {
        return Ok();
    }
}