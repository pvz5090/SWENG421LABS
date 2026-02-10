using System;

public abstract class InputModule : Module
{
	protected double input = 0;
	public InputModule(double x)
	{
		this.input = x;
	}

	protected double collectInput()
	{
		return input;  
    }
}
