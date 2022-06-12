using AbstractFactory.Factory.Products.Chair;
using AbstractFactory.Factory.Products.Table;

namespace AbstractFactory.Factory.Factories
{
    public abstract class GenericFactory<TChair, TTable> : IFactory 
        where TChair : IChair, new()
        where TTable : ITable, new()
    {
        public IChair GetChair()
        {
            return new TChair();
        }
        public ITable GetTable()
        {
            return new TTable();
        }
    }
}
