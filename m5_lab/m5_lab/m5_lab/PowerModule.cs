using System;

public class PowerModule : InputModule  
{
	public PowerModule(string name, TextBox inputTextBox) : base(name, inputTextBox) {}

	private void power(double input)
	{
		value = Math.Pow(value, input); 
	}


	public override void compute()
	{
		power(this.collectInput());
		Console.WriteLine("value:" + value);
	}
}
