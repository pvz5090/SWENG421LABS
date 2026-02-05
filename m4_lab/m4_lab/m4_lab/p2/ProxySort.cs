using p1;
namespace p2;
public class ProxySort<T> : SortUtility<T> where T : IComparable {
    public ProxySort(string sortName) : base(sortName) {}
    private Dictionary<string, string> GetSortAlgoMap()
    {
        Dictionary<String, String> sortAlgos = new Dictionary<String, String>();
        sortAlgos.Add("quicksort", "p1.QuicksortUtility`1");
        sortAlgos.Add("bubblesort", "p2.BubblesortUtility`1");
        return sortAlgos;
    }

    public override List<T> sort(List<T> data) {
        Dictionary<String, String> sortAlgos = GetSortAlgoMap();
        try
        {
            string sortAlgo = sortAlgos[base.getName()];
            Console.WriteLine(sortAlgo);
            Type genericType = Type.GetType(sortAlgo);
            Type type = genericType.MakeGenericType(typeof(T));
            SortUtility <T> client = (SortUtility<T>)Activator.CreateInstance(type);

            data = client.sort(data);
            return data;
        }
        catch (KeyNotFoundException ke)
        {
            Console.Error.WriteLine("Could not find sorting algorithm " + base.getName());
            throw new Exception(ke.Message);
        }
    }
}

