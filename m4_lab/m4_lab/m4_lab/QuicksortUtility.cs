using p2;
namespace p1
{
    public class QuicksortUtility<T> : SortUtility<T> where T : IComparable
    {
        public QuicksortUtility() : base("quicksort") {}
        public virtual List<IComparable> sort(List<IComparable> data)
        {
            data.Sort();
            return data;
        }
    }
}