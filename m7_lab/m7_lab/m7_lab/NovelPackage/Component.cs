namespace NovelPackage{ 
    public interface Component
    {
        public void save(); 
        public void retrieve();
        public void view();
        public void edit(string text);
        public void delete();
    }
} 