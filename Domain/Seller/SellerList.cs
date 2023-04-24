
namespace rent3s.Domain.Seller;  

public class SellerList : Shared.ItemBase{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Image { get; set; } 
    public bool Active { get; set; }
}