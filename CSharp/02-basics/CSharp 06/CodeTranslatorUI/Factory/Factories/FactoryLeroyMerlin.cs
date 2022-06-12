using AbstractFactory.Factory.Products.Chair;
using AbstractFactory.Factory.Products.Table;

namespace AbstractFactory.Factory.Factories
{
    public class FactoryLeroyMerlin : GenericFactory<ChairLeroyMerlin, TableLeroyMerlin>
    {
    }
}
