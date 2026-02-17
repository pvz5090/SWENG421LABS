using System;

public class ProductModule : InputModule  
{
	public ProductModule(string name) : base(name) {}

	private void product(double input)
	{
		value *= input; 
	}

	public override void compute()
	{
		product(this.collectInput());
		Console.WriteLine("value:" + value);
	}
}
