using System;

public class InitializeModule : InputModule  
{
	public InitializeModule(string name) : base(name) {}

	private void initialize(double input)
	{
		value = input; 
	}

	public override void compute()
	{
		initialize(this.collectInput());
		Console.WriteLine("value:" + value);
	}
}
