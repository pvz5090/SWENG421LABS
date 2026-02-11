using System;

public class LogModule : InputModule  
{
	public LogModule(string name) : base(name) {}

	private void log()
	{
		value = Math.Log(value); 
	}


	public override void compute()
	{
		log();
		Console.WriteLine("value:" + value);
	}
}
