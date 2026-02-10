using System;

public class Module : IComparable
{
	protected static double value;
	private string name;

	public Module(string name)
	{
		this.name = name;
	}

	public abstract compute(); 

	public int CompareTo(object obj)
	{
		return name.CompareTo(obj.name);
	}

}
