using p2;

SortUtility<Desk> sorter = new ProxySort<Desk>("bubblesort");

List<Desk> deskList = new List<Desk>();
deskList.Add(new Desk(1, "Desk1", 1));
deskList.Add(new Desk(3, "Desk3", 3));
deskList.Add(new Desk(5, "Desk5", 5));
deskList.Add(new Desk(4, "Desk4", 4));
deskList.Add(new Desk(2, "Desk2", 2));
Console.WriteLine(deskList);
List<Desk> sorted = sorter.sort(deskList);
Console.WriteLine(sorted);
