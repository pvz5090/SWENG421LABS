using p2;

namespace p1;

public class MyProg {

    public static void Main(String[] args)
    {
        Company xyz = new Company();
        List<ProductIF> listOfProducts = getProducts();
        xyz.sortUtility = new ProxySort<ProductIF>("bubblesort");
        listOfProducts= xyz.sortUtility.sort(listOfProducts);

        foreach (ProductIF product in listOfProducts)
            Console.WriteLine(product.getPrice());


        List<ProductIF> listOfProducts2 = getProducts();
        xyz.sortUtility.setName("quicksort");
        listOfProducts2 = xyz.sortUtility.sort(listOfProducts);

        foreach (ProductIF product in listOfProducts2)
            Console.WriteLine(product.getPrice());

    }

    public static List <ProductIF> getProducts()
    {
        return new List<ProductIF> {new Desk(1, "writing", 20.30),
                                                                new Desk(2, "corner", 15.25),
                                                                new Desk(3, "lap", 25.13),
                                                                new Desk(4, "standing", 15.85),
                                                                new Desk(5, "floating", 22.56)};
    }
}