// public class ProxySort<T> {
//     private SortUtility<T> client;

//     public void setSortUtility(SortUtility<T> sortUtility) {
//         this.client = sortUtility;
//     }

//     public List sort(List data) {
//         return sortUtility.sort(data);
//     }

//     public virtual List sort(List data) {
//         // impl bubblesort
//     }
// }

namespace p2
{
    public class ProxySort<T> : SortUtility<T> where T : ProductIF {
        public ProxySort(string sortName) : base(sortName) {}

        public override List<IComparable> sort(List<IComparable> data) {
            SortUtility<ProductIF> client;

            if (base.getName() == "bubblesort") {
                client = new BubblesortUtility<ProductIF>();
            } else if (base.getName() == "quicksort") {
                client = new QuicksortUtility<ProductIF>();
            } else {
                throw new Exception("Sorting algorithm not found");
            }

            return client.sort(data);
        }
    }
}
