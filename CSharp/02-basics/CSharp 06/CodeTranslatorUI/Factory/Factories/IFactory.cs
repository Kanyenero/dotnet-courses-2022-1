using AbstractFactory.Factory.Products.Chair;
using AbstractFactory.Factory.Products.Table;

namespace AbstractFactory.Factory.Factories
{
    public interface IFactory
    {
        IChair GetChair();
        ITable GetTable();
    }
}
