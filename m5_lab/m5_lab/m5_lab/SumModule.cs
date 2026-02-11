using System;

public class SumModule : InputModule  
{
	public SumModule(double x) : base(x) { }
	private void sum(double input)
	{
		value += input; 
	}

	public void Compute()
	{
		sum(this.collectInput());
		Console.WriteLine("value:" + value);
	}
}
