using System;

public abstract class Module : IComparable
{
	protected static double value;
	protected static TextBox inputTextBox;
	private string name;

	public Module(string name, TextBox inputTextBox)
	{
		this.name = name;
		Module.inputTextBox = inputTextBox;
	}
<<<<<<< HEAD
		
	public abstract double Compute(); 
=======

	public abstract void compute();

    public override string ToString()
    {
        return name;
    }
>>>>>>> ba37426e88b6402ed109041dcb0df8c6286326e0

	public int CompareTo(object obj)
	{
		return this.ToString().CompareTo(obj.ToString());
	}

}
