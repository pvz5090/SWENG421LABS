namespace NovelPackage;
public class Character : LineOfTextComponent
{
    string chara;

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
<<<<<<< HEAD
        Console.Write(chara.ToString());
        //Console.WriteLine("Viewing The Character");
=======
        Console.WriteLine(chara);
>>>>>>> 35ec5e0254b31f4f4ecf46437794d1b8f8e40230
    }
}