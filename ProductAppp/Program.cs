using ProductAppp;

internal class Program
{
    private static void Main(string[] args)
    {
        Repository<Product> repository = new Repository<Product>();
        repository.AddProduct(new Product("milk"));
        repository.AddProduct(new Product("meat"));
        repository.AddProduct(new Product("rice"));

        
        foreach (Product product in repository.get()) 
        {
            Console.WriteLine(product.getName());
        }
        // we can't do repository.getProducts() because the return value will be like this : System.Collections.Generic.List`1[ProductAppp.Product]
        // which  it’s simply the way the type is represented internally in the .NET framework
        // ,So we used repository.get().getname();
    }
}