namespace p2
{
    public class BubblesortUtility<T> : SortUtility<ProductIF> where T : ProductIF {
        BubblesortUtility(string sortName) : base(sortName) {}
    }
}