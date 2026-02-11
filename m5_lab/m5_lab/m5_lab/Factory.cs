
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

    public Module createModule(string moduleName, TextBox inputTextBox)
    {
        string moduleString = hashMap[moduleName];
        Console.WriteLine(moduleString);
        Type moduleType = Type.GetType(moduleString);
        Console.WriteLine(moduleString);
        return (Module)Activator.CreateInstance(moduleType, moduleString, inputTextBox);
    }
}
