using System;

public class SumModule : InputModule  
{
	public SumModule(string name, TextBox inputTextBox) : base(name, inputTextBox) {}

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
