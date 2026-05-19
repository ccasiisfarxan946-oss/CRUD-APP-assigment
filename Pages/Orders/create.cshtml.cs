using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CreateModel: PageModel
{
    private readonly AppDbContext _context;
    public CreateModel(AppDbContext context)
    {
        _context=context;
    }

[BindProperty]
public required string	CustomerName	{	get;	set;	}
[BindProperty]	
public required string	ProductName	{	get;	set;	}	
[BindProperty]
public required int	quantity	{	get;	set;	}
[BindProperty]
public required decimal	Price	{	get;	set;	}	
[BindProperty]
public required DateTime	OrderDate	{	get;	set;	}


public IActionResult OnPost()
    {
        var Order = new Order
        {
            CustomerName = CustomerName,
            ProductName = ProductName,
            quantity = quantity,
            Price = Price,
            OrderDate = OrderDate
        };
        _context.Orders.Add(Order);
        _context.SaveChanges();

        return RedirectToPage("Product");
    }
   

    

}
