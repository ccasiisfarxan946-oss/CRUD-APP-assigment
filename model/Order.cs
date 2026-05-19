using	System.ComponentModel.DataAnnotations;	
public	class	Order	
{	
	
public	int	ID	{	get;	set;	}	
public required string	 CustomerName 	{	get;	set;	}	
public required string	 ProductName	{	get;	set;	}	
public required int	quantity	{	get;	set;	}	
public required decimal	Price	{	get;	set;	}	

public required	DateTime OrderDate	{	get;	set;	}	

}