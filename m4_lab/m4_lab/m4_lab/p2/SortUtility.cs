namespace m4_lab.p2;
 
{
    public class SortUtility<T> where T : IComparable {
        private string sortName = "bubblesort";

        public SortUtility(string sortName) {
            this.sortName = sortName;
        }

        public string getName() { return sortName; }
        public void setName(string sortName) { this.sortName = sortName; }

        public virtual List<T> sort(List<T> data) {
        int n = data.Count;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                // T is guaranteed to have CompareTo because of the 'where T : IComparable' constraint
                if (data[j].CompareTo(data[j + 1]) > 0) {
                    T temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
        return data;

    }
}
