namespace NovelPackage;
public class Character : LineOfTextComponent
{
    string chara;

    public Character(string c)
    {
        chara=c;
    }
    public void save()
    {
        Console.WriteLine("Saving The Character");
    }

    public void edit(string text)
    {
        Console.WriteLine("Editing The Character");
        this.chara = text;
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

        Console.Write(chara.ToString());


    }
}