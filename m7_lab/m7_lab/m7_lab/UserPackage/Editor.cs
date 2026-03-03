using NovelPackage;
namespace UserPackage{ 
    public class Editor : User
    {
        public Editor()
        {
            this.componentType = typeof(EditorComponent);
        }
    }
}