
using System;

public class Factory
{
    private Dictionary<string, string> hashMap;
	public Factory()
	{
        hashMap.Add("Power", "PowerModule");
        hashMap.Add("Log", "LogModule");
        hashMap.Add("Sum", "SumModule");
        hashMap.Add("Subtract", "SubtractModule");
        hashMap.Add("Initialize", "InitializeModule");
    }

    public Module createModule(string moduleName)
    {
        string mduleString = hashMap[moduleName];
        Console.WriteLine(mduleString);
        Type moduleType = Type.GetType(mduleString);
        Console.WriteLine(mduleString);
        return (Module)Activator.CreateInstance(moduleType, mduleString);
    }
}
