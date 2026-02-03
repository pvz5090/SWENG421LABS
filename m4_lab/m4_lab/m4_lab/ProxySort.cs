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

public class ProxySort : SortUtility where T : ProductIF {
    public override List sort(List data) {
        private SortUtility<T> client;

        if (base.getName() == "bubblesort") {
            client = new BubblesortUtility<T>();
        } else if (base.getName() == "quicksort") {
            client = new QuicksortUtility<T>();
        } else {
            throw new NotFoundError("Sorting algorithm not found");
        }

        return sortUtility.sort(data);
    }
}