using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class FactoryIkea : GenericFactory<ChairIkea, TableIkea>
    {
    }
}
