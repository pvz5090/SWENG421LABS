using System;

public abstract class InputModule : Module
{
	protected double input;
	public InputModule()
	{
		this.input = 0;
	}

	protected double collectInput()
	{
		return input;  
    }
}
