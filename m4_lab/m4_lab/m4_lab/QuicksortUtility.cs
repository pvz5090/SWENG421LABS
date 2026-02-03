namespace p2
{
    public class QuicksortUtility<T> : SortUtility<T> where T : ProductIF, IComparable<T>
    {
        QuicksortUtility(string sortName) : base(sortName) {}
        public virtual List<T> sort(List<T> data)
        {

        }
    }
}