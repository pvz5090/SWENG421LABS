using p1;
namespace p2;
public class ProxySort<T> : SortUtility<T> where T : IComparable {
    public ProxySort(string sortName) : base(sortName) {}

    public override List<T> sort(List<T> data) {
        SortUtility<T> client;
        if (base.getName() == "bubblesort") {
            client = new BubblesortUtility<T>();
        } else if (base.getName() == "quicksort") {
            client = new QuicksortUtility<T>();
        } else {
            throw new Exception("Sorting algorithm not found");
        }
        data = client.sort(data);
        return data;
    }
    
    public void print(List<ProductIF> data)
    {
        if (base.getName() == "bubblesort")
        {
            var client = new BubblesortUtility<ProductIF>();
            client.print(data);
        }
        else if (base.getName() == "quicksort")
        {
            var client = new QuicksortUtility<ProductIF>();
        }
        else
        {
            throw new Exception("printing algorithm not found");
        }
    }
}

