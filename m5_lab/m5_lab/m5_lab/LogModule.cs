using System;

public class LogModule : InputModule  
{
	public LogModule(string name, TextBox inputTextBox) : base(name, inputTextBox) {}

	private void log(double input)
	{
		value = Math.Log(value, input); 
	}


	public override void compute()
	{
		log(this.collectInput());
		Console.WriteLine("value:" + value);
	}
}
