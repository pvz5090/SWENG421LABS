using p2;
namespace p1
{
    public class QuicksortUtility<T> : SortUtility<T> where T : IComparable
    {
        public QuicksortUtility() : base("quicksort") {}
        public override List<T> sort(List<T> data)
        {
            Console.WriteLine("This is working inside quicksort");
            data.Sort();
            return data;
        }
    }
}