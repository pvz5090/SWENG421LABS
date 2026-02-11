using System;

public abstract class Module : IComparable
{
	protected static double value;
	public static TextBox inputTextBox;
	public static TextBox outputTextBox;
	private string name;

	public Module(string name)
	{
		this.name = name;
		inputTextBox = inputTextBox;

	}

	public abstract void compute();

    public override string ToString()
    {
        return name;
    }
    public static double getValue()
    {
        return value;
    }

    public int CompareTo(object obj)
	{
		return this.ToString().CompareTo(obj.ToString());
	}

}
