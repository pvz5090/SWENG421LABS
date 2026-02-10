using System;

public class SumModule : InputModule
{
	private void sum(double input)
	{
		this.value += input;
	}

	public void compute()
	{
		double input = this.collectInput()
		sum(input)
	}
}
