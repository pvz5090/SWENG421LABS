using System;

public abstract class Module : IComparable
{
	protected static double value;
	private string name;

	public Module(string name)
	{
		this.name = name;
	}
		
	public abstract double Compute(); 

	public int CompareTo(object obj)
	{
		return name.CompareTo(obj.name);
	}

}
