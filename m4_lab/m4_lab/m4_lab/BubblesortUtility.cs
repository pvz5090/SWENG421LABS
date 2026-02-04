namespace p2
{
    public class BubblesortUtility<T> : SortUtility<T> where T : IComparable {
        public BubblesortUtility() : base("bubblesort") {}
        public void print(List<ProductIF> data)
        {
            foreach (var product in data)
                Console.WriteLine(product.getId() + ", " + product.getName() + ", " + product.getPrice() + "\n");
        }
    }
}