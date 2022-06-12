namespace AbstractFactory.Factory.Products.Table
{
    public class TableIkea : ITable
    {
        public int GetId()
        {
            return 777;
        }
        public string GetName()
        {
            return "Ikea Table Name: ...";
        }
    }
}