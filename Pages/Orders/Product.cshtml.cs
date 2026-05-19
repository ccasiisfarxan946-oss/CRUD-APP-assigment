using Azure; 
using Microsoft.AspNetCore.Mvc.RazorPages; 
 
public class ProductModel(AppDbContext context) : PageModel 
{ 
    // Connect to Database  
    private readonly AppDbContext _context = context;

    public required List<Order> Orders {get; set;} 
 
    public void OnGet() 
    { 
        Orders=_context.Orders.ToList();


    }
}