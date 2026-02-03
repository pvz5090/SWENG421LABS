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
        public override List<T> sort(List<T> data) {
            SortUtility<ProductIF> client;

            if (base.getName() == "bubblesort") {
                client = new BubblesortUtility<T>();
            } else if (base.getName() == "quicksort") {
                client = new QuicksortUtility<T>();
            } else {
                throw new NotFoundError("Sorting algorithm not found");
            }

            return client.sort(data);
        }
    }
}
