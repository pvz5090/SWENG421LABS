using p2;

SortUtility<Desk> sorter = new ProxySort<Desk>("bubblesort");

List<Desk> deskList = new List<Desk>();
deskList.Add(new Desk())
Console.WriteLine(deskList);
List<Desk> sorted = sorter.sort(deskList);
Console.WriteLine(sorted);
