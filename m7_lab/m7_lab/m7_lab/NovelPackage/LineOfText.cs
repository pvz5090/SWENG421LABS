using System.Reflection.PortableExecutable;

namespace NovelPackage;
public class LineOfText:ColumnComponent
{
    private List <LineOfTextComponent> component;

    public LineOfText()
    {
         component=new List <LineOfTextComponent>();
    }

     public void save()
    {
        Console.WriteLine("Saving The Line of Text");
    }

    public void edit(string text)
    {
        Console.WriteLine("Editing The Line of Text");
        component.Clear();
        foreach (char c in text)
        {
            component.Add(new NovelPackage.Character(c.ToString()));
        }
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
        foreach (LineOfTextComponent lotc in component)
        {
            lotc.view();
        }
        
        //Console.WriteLine("Viewing The Line of Text");
    }
}