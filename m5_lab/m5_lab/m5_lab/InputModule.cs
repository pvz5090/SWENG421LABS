using System;

public abstract class InputModule : Module
{
	public InputModule(string name) : base(name) {}


	protected double collectInput()
	{
		return Double.Parse(inputTextBox.Text);
    }
}
