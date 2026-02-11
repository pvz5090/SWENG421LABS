using System;

public class SumModule : InputModule  
{
	public SumModule(string name) : base(name) {}

	private void sum(double input)
	{
		value += input; 
	}


	public override void compute()
	{
		sum(this.collectInput());
		Console.WriteLine("value:" + value);
	}
}
