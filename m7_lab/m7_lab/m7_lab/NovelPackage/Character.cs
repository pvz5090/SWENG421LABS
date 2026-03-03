namespace NovelPackage;
public class Character : LineOfTextComponent
{
    private char chara;

        public void save()
    {
        Console.WriteLine("Saving The Character");
    }

    public void edit()
    {
        Console.WriteLine("Editing The Character");
    }

    public void retrieve()
    {
        Console.WriteLine("Retreiving Character");
    }

    public void delete()
    {
        Console.WriteLine("Deleting The Character");
    }

    public void view()
    {
        Console.WriteLine("Viewing The Character");
    }
}