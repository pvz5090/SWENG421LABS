using System.Runtime.CompilerServices;

namespace NovelPackage;
public class Novel : AdminComponent
{
    public List<NovelComponent> components;
    
    public Novel()
    {
        components=new List<NovelComponent>();
    }
    public void save()
    {
        Console.WriteLine("Saving The Novel Components");
    }

    public void edit(string text)
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
