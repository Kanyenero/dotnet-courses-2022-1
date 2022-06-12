namespace AbstractFactory.Product
{
    public class CupboardLeroyMerlin : IProduct
    {
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Type Type { get; set; }
        public Material Material { get; set; }
        public Footprint Footprint { get; set; }

        public CupboardLeroyMerlin(int id, string name, double price, Type type, Material material, Footprint footprint)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
            Material = material;
            Footprint = footprint;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Price}\t{Type}\t{Material}\t{Footprint}";
        }
    }
}
