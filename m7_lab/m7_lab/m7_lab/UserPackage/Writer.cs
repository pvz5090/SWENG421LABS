using NovelPackage;
namespace UserPackage{ 
    public class Writer : User
    {
        public Writer()
        {
            this.componentType = typeof(WriterComponent);
        }
    }
}