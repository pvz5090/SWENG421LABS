using System;

public abstract class InputModule : Module
{
	public InputModule(string name, TextBox inputTextBox) : base(name, inputTextBox) {}


	protected double collectInput()
	{
		return Double.Parse(inputTextBox.Text);
    }
}
