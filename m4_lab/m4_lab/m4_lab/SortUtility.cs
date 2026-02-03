namespace p2
{
    public class SortUtility<T> where T : ProductIF {
        private string sortName = "bubblesort";

        public SortUtility(string sortName) {
            this.sortName = sortName;
        }

        public string getName() { return sortName; }
        public void setName(string sortName) { this.sortName = sortName; }

        public virtual List<IComparable> sort(List<IComparable> data) {
            int n = data.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (data[j].CompareTo(data[j + 1]) > 0)
                    {
                        IComparable temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
            return data;
        }
    }
}