package p2;
public class SortUtility where T : ProductIF {
    private string sortName = "bubblesort";

    public SortUtility(string sortName) {
        this.sortName = sortName;
    }

    public string getName() { return sortName; }
    public void setName(string sortName) { this.sortName = sortName; }

    public virtual List sort(List data) {
        // impl bubblesort
    }
}