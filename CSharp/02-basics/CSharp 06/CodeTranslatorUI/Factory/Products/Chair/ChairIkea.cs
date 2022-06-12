namespace AbstractFactory.Factory.Products.Chair
{
    public class ChairIkea : IChair
    {
        public int GetId()
        {
            return 777;
        }
        public string GetName()
        {
            return "Ikea Chair Name: ...";
        }
    }
}