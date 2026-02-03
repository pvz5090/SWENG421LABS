namespace p2
{
    public class SortUtility<T> where T : ProductIF {
        private string sortName = "bubblesort";

        public SortUtility(string sortName) {
            this.sortName = sortName;
        }

        public string getName() { return sortName; }
        public void setName(string sortName) { this.sortName = sortName; }

        public virtual List<T> sort(List<T> data) {
            // impl bubblesort
        }
    }
}