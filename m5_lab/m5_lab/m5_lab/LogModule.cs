using System;

public class LogModule : Module
{
	public LogModule(string name, TextBox inputTextBox) : base(name, inputTextBox) {}

	private void log(double input)
	{
		value = Math.Log(value, input); 
	}


	public override void compute()
	{
		Console.WriteLine("value:" + value);
	}
}
