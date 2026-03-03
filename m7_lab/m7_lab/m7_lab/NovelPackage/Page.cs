namespace NovelPackage;
public class Page:NovelComponent
{
    private List<PageComponent> components;

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
        foreach ( PageComponent item in components)
        {
            item.view();
        }
        //Console.WriteLine("Viewing The Page Components");
    }
}