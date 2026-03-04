namespace NovelPackage;
public class LineOfText:ColumnComponent
{
    private LineOfTextComponent component;

    public LineOfText(LineOfTextComponent lot)
    {
        component=lot;
    }
     public void save()
    {
        Console.WriteLine("Saving The Line of Text");
    }

    public void edit(string text)
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
        component.view();
        
        //Console.WriteLine("Viewing The Line of Text");
    }
}