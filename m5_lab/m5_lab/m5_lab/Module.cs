using System;

public abstract class Module : IComparable
{
	protected static double value;
	protected TextBox inputTextBox;
	private string name;

	public Module(string name, TextBox inputTextBox)
	{
		this.name = name;
		this.inputTextBox = inputTextBox;
	}

	public abstract void compute();

    public override string ToString()
    {
        return name;
    }

	public int CompareTo(object obj)
	{
		return this.ToString().CompareTo(obj.ToString());
	}

}
