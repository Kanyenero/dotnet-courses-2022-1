using AbstractFactory.Factory.Factories;

namespace AbstractFactory.AbstractFactoryUI
{
    internal class Program
    {
        private static void Main()
        {
            var factories = new IFactory[2]
            {
                new FactoryIkea(),
                new FactoryLeroyMerlin()
            };

            foreach (var factory in factories)
            {
                Console.WriteLine($"Id: {factory.GetChair().GetId()}");
                Console.WriteLine($"{factory.GetChair().GetName()}");
                Console.WriteLine($"Id: {factory.GetTable().GetId()}");
                Console.WriteLine($"{factory.GetTable().GetName()}");
            }
        }
    }
}
