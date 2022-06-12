using AbstractFactory.Factory.Products.Chair;
using AbstractFactory.Factory.Products.Table;

namespace AbstractFactory.Factory.Factories
{
    public class FactoryIkea : GenericFactory<ChairIkea, TableIkea>
    {
    }
}
