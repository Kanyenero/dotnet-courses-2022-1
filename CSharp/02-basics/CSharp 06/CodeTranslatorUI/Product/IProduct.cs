namespace AbstractFactory.Product
{
    public interface IProduct
    {
        int Id { get; }
        string Name { get; set; }
        double Price { get; set; }
        Type Type { get; set; }
        Material Material { get; set; }
        Footprint Footprint { get; set; }
    }
}