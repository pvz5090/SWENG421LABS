namespace NovelPackage;
public class Frame:ColumnComponent
{
    private List<FrameComponent> components;

    public Frame()
    {
        components=new List<FrameComponent>();
    }

        public void save()
    {
        Console.WriteLine("Saving The Frame");
    }

    public void edit(string text)
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
        foreach ( FrameComponent item in components)
        {
            item.view();
        }
        //Console.WriteLine("Viewing The Frame");
    }
}