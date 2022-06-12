namespace AbstractFactory.Factory.Products.Chair
{
    public class ChairLeroyMerlin : IChair
    {
        public int GetId()
        {
            return 999;
        }
        public string GetName()
        {
            return "LeroyMerlin Chair Name: ...";
        }
    }
}
