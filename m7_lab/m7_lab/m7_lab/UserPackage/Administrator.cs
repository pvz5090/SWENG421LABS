using NovelPackage;
namespace UserPackage{ 
    public class Administrator : User
    {
        public Administrator() {
            this.componentType = typeof(AdminComponent);
        }
    }
}