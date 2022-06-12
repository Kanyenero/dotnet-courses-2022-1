namespace AbstractFactory.Products
{
    public class TableLeroyMerlin : ITable
    {
        public int GetId()
        {
            return 999;
        }
        public string GetName()
        {
            return "LeroyMerlin Table Name: ...";
        }
    }
}
