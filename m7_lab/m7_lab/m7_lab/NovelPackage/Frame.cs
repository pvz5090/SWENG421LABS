namespace NovelPackage;
public class Frame:ColumnComponent
{
    public List<FrameComponent> component;

        public void save()
    {
        Console.WriteLine("Saving The Frame");
    }

    public void edit()
    {
        Console.WriteLine("Editing The Frame");
    }

    public void retrieve()
    {
        Console.WriteLine("Retreiving The Frame");
    }

    public void delete()
    {
        Console.WriteLine("Deleting The Frame");
    }

    public void view()
    {
        Console.WriteLine("Viewing The Frame");
    }
}