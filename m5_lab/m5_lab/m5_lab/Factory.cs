
using System;

public class Factory
{
    private Dictionary<string, string> hashMap = new Dictionary<string, string> { };
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
        string moduleString = hashMap[moduleName];
        Console.WriteLine(moduleString);
        Type moduleType = Type.GetType(moduleString);
        Console.WriteLine(moduleString);
        return (Module)Activator.CreateInstance(moduleType, moduleString);
    }
}
