using NovelPackage;
using UserPackage;

public class Program
{
    public int main()
    {
        Novel novel = new Novel();
        novel.component.Add(new Page());  
        dynamic page = novel.component[0];
        page.component.Add(new Column());
        page.component.Add(new Frame());
        dynamic column = page.component[0]; 
        column.component.Add(new LineOfText());
        dynamic lof = column.component[0]; 
        lof.edit("SWENG");
        dynamic frame = page.component[1]; 
        frame.component.Add(new Column()); 
        dynamic columnInFrame = frame.component[0]; 
        columnInFrame.component.Add(new LineOfText());
        dynamic lofInColumnInFrame = columnInFrame.component[0];
        lofInColumnInFrame.edit("421");
        Writer writer = new Writer();

        writer.doStuff(novel, "view");

        return 0; 
    }
}