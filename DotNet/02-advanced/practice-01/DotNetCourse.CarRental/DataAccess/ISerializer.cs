namespace DotNetCourse.CarRental.DataAccess
{
    public interface ISerializer
    {
        bool TrySerializeCollection<TItem>(IEnumerable<TItem> collection) 
            where TItem : class, IComparable<TItem>;
    }
}
