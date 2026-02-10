
using System;

public class Factory
{
	public Factory()
	{

	}

	public Module createModule(string moduleName)
	{
		return new Module(moduleName);
	}
}
