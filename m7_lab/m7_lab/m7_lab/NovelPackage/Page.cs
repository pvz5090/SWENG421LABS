namespace NovelPackage;
public class Page:NovelComponent
{
    private List<PageComponent> component;

     public void save()
    {
        Console.WriteLine("Saving The Page Components");
    }

    public void edit()
    {
        Console.WriteLine("Editing The Page Components");
    }

    public void retrieve()
    {
        Console.WriteLine("Retreiving The Page Components");
    }

    public void delete()
    {
        Console.WriteLine("Delete The Page Components");
    }

    public void view()
    {
        Console.WriteLine("Viewing The Page Components");
    }
}