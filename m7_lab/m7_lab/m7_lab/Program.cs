using NovelPackage;

public class Program
{
    public int main()
    {
        Novel novel = new Novel("SWENG 421");
        novel.component.Add(new Page()); 
        return 0; 
    }
}