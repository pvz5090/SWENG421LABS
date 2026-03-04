namespace NovelPackage;
public class LineOfText:ColumnComponent
{
    private LineOfTextComponent component;

     public void save()
    {
        Console.WriteLine("Saving The Line of Text");
    }

    public void edit()
    {
        Console.WriteLine("Editing The Line of Text");
    }

    public void retrieve()
    {
        Console.WriteLine("Retreiving The Line of Text");
    }

    public void delete()
    {
        Console.WriteLine("Delete The Line of Text");
    }

    public void view()
    {
        Console.WriteLine("Viewing The Line of Text");
    }
}