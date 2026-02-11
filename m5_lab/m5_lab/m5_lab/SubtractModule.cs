using System;

public class SubtractModule : InputModule  
{
	public SubtractModule(string name) : base(name) {}

	private void subtract(double input)
	{
		value -= input; 
	}

	public override void compute()
	{
		subtract(this.collectInput());
		Console.WriteLine("value:" + value);
	}
}
