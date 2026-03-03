namespace NovelPackage;
public class Novel : Component
{
    private List<NovelComponent> component;

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
        Console.WriteLine("Viewing The Novel Components");
    }


}