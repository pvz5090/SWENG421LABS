using System;

public class ProductModule : InputModule  
{
	public ProductModule(string name, TextBox inputTextBox) : base(name, inputTextBox) {}

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
