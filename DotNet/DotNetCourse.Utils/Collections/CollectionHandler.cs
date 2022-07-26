using System.Linq.Expressions;

namespace DotNetCourse.Utils.Collections
{
    public static class CollectionHandler
    {
        public static bool TryGetItem<TCollection, TItem>(this TCollection collection, TItem itemToGet, out TItem? outputItem)
            where TCollection : IEnumerable<TItem>
            where TItem : IEquatable<TItem>
        {
            outputItem = collection
                .Where(i => i.Equals(itemToGet))
                .SingleOrDefault();

            if (outputItem == null)
                return false;

            return true;
        }

        public static bool TryGetItemOn<TCollection, TItem>(this TCollection collection, Func<TItem, bool> function, out TItem outputItem)
            where TCollection : IEnumerable<TItem>
        {
            outputItem = collection
                .Where(function)
                .SingleOrDefault();

            if (outputItem == null)
                return false;

            return true;
        }
    }
}
