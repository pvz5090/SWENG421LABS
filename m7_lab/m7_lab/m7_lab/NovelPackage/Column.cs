namespace NovelPackage;

public class Column:FrameComponent
{
    private List<ColumnComponent> components;

        public void save()
    {
        Console.WriteLine("Saving The Column");
    }

    public void edit()
    {
        Console.WriteLine("Editing The Column");
    }

    public void retrieve()
    {
        Console.WriteLine("Retreiving The Column");
    }

    public void delete()
    {
        Console.WriteLine("Deleting The Column");
    }

    public void view()
    {
        foreach ( ColumnComponent item in components)
        {
            item.view();
        }
        //Console.WriteLine("Viewing The Column");
    }


}