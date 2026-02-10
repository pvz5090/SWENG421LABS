using System;

public abstract class InputModule : Module
{
	double value = 0;
	public InputModule(double x)
	{
		this.value = x;
	}

	protected double collectInput()
	{
		return value;  
    }
}
