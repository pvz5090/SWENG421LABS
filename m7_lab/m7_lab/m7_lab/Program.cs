using NovelPackage;
using UserPackage;

public class Program
{
    public static int Main()
    {
        Novel novel = new Novel();
        novel.components.Add(new Page());  
        dynamic page = novel.components[0];
        page.components.Add(new Column());
        page.components.Add(new Frame());
        dynamic column = page.components[0]; 
        column.components.Add(new LineOfText());
        dynamic lof = column.components[0]; 
        lof.edit("SWENG");
        dynamic frame = page.components[1]; 
        frame.components.Add(new Column()); 
        dynamic columnInFrame = frame.components[0]; 
        columnInFrame.components.Add(new LineOfText());
        dynamic lofInColumnInFrame = columnInFrame.components[0];
        lofInColumnInFrame.edit("421");
        Writer writer = new Writer();

        writer.doStuff(novel, "view");

        return 0; 
    }
} 