using AbstractFactory.Factory.Products.Chair;
using AbstractFactory.Factory.Products.Table;
using AbstractFactory.Factory.Factories;

namespace AbstractFactory.Client
{
    public class Client
    {
        public IChair Chair { get; set; }
        public ITable Table { get; set; }

        public Client (IFactory parameter)
        {
            Chair = parameter.GetChair();
            Table = parameter.GetTable();
        }
    }
}