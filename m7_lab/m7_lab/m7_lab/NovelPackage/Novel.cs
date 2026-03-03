using System.Runtime.CompilerServices;

namespace NovelPackage;
public class Novel : Component
{
    private List<NovelComponent> components;

    public void save()
    {
        Console.WriteLine("Saving The Novel Components");
    }

    public void edit()
    {
        Console.WriteLine("Editing The Novel Components");
    }

    public void retrieve()
    {
        Console.WriteLine("Retreiving The Novel Components");
    }

    public void delete()
    {
        Console.WriteLine("Delete The Novel Components");
    }

    public void view()
    {
        foreach ( NovelComponent item in components)
        {
            item.view();
        }
        
        //Console.WriteLine("Viewing The Novel Components");
    }


}