namespace NovelPackage
{
    public interface EditorComponent : Component
    {
        public void save();
        public void retrieve();
        public void delete();
    }
}
