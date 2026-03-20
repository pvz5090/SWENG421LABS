namespace NovelPackage;
public class Image:LineOfTextComponent
{
        public void save()
    {
        Console.WriteLine("Saving The Image");
    }

    public void edit(string text)
    {
        Console.WriteLine("Editing The Image");
    }

    public void retrieve()
    {
        Console.WriteLine("Retreiving The Image");
    }

    public void delete()
    {
        Console.WriteLine("Delete The Image");
    }

    public void view()
    {
       // Console.WriteLine("Viewing The Image");
    }
}