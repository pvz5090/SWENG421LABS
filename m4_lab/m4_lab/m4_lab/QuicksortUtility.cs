namespace p1
{
    public class QuicksortUtility<T> : SortUtility<T> where T : ProductIF
    {
        public QuicksortUtility() : base("quicksort") {}
        public virtual List<IComparable> sort(List<IComparable> data)
        {
            throw new NotImplementedException();
        }
    }
}