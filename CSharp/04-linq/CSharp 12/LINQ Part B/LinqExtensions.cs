using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasksReinvent
{
    public static class LinqExtensions
    {
        public static IEnumerable<TSource> Repeat<TSource>(this IEnumerable<TSource> source, int count)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            if (source.ToList().Count > 1) throw new ArgumentException(nameof(count));

            for (int counter = 0; counter < count; counter++)
                yield return source.First();
        }

        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            Validate<IEnumerable<TSource>>.NotNull(first, nameof(first));
            Validate<IEnumerable<TSource>>.NotNull(second, nameof(second));

            foreach (var item in first) 
                yield return item;

            foreach (var item in second) 
                yield return item;
        }

        public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));

            foreach (var item in source)
            {
                yield return item;

                if (--count == 0) 
                    break;
            }
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            Validate<Func<TSource, bool>>.NotNull(predicate, nameof(predicate));

            foreach (var item in source)
            {
                if (predicate(item)) 
                    return item;
            }

            return default;
        }

        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));

            return new List<TSource>(source);
        }

        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            Validate<Func<TSource, int, bool>>.NotNull(predicate, nameof(predicate));

            int index = 0;

            foreach (var item in source)
            {
                if (predicate(item, index)) 
                    yield return item;

                index++;
            }
        }

        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            Validate<Func<TSource, bool>>.NotNull(predicate, nameof(predicate));

            foreach (var item in source)
            {
                if (predicate(item)) 
                    return true;
            }

            return false;
        }

        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            Validate<TSource>.NotNull(value, nameof(value));
            Validate<IEqualityComparer<TSource>>.NotNull(comparer, nameof(comparer));

            return source.Any(item => comparer.Equals(value, item));
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            Validate<Func<TSource, int, TResult>>.NotNull(selector, nameof(selector));

            int index = 0;

            foreach (var item in source)
            {
                yield return selector(item, index);
                index++;
            }
        }

        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            Validate<Func<TSource, IEnumerable<TResult>>>.NotNull(selector, nameof(selector));

            foreach (var outterItem in source)
            {
                foreach (var innerItem in selector(outterItem))
                {
                    yield return innerItem;
                }
            }
        }

        public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            Validate<Func<TSource, TSource, TSource>>.NotNull(func, nameof(func));

            using (var iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext()) throw new InvalidOperationException("Source sequence was empty");

                var current = iterator.Current;

                while (iterator.MoveNext())
                {
                    current = func(current, iterator.Current);
                }

                return current;
            }
        }

        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));

            var seenElements = new HashSet<TSource>(EqualityComparer<TSource>.Default);

            foreach (var item in source)
            {
                if (seenElements.Add(item))
                    yield return item;
            }
        }

        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            Validate<IEnumerable<TSource>>.NotNull(first, nameof(first));
            Validate<IEnumerable<TSource>>.NotNull(second, nameof(second));

            var potentialElements = new HashSet<TSource>(second, EqualityComparer<TSource>.Default);

            foreach (var item in first)
            {
                if (potentialElements.Remove(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector, 
            Func<TSource, TElement> elementSelector,
            Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
            Validate<IEnumerable<TSource>>.NotNull(source, nameof(source));
            Validate<Func<TSource, TKey>>.NotNull(keySelector, nameof(keySelector));
            Validate<Func<TSource, TElement>>.NotNull(elementSelector, nameof(elementSelector));
            Validate<Func<TKey, IEnumerable<TElement>, TResult>>.NotNull(resultSelector, nameof(resultSelector));

            var dictionary = new Dictionary<TKey, List<TElement>>();

            foreach (var item in source)
            {
                var key = keySelector(item);
                var element = elementSelector(item);

                if (!dictionary.ContainsKey(key))
                    dictionary.Add(key, new List<TElement>());

                dictionary[key].Add(element);
            }

            foreach (var kvp in dictionary)
            {
                yield return resultSelector(kvp.Key, kvp.Value);
            }
        }

        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(
            this IEnumerable<TOuter> outer, 
            IEnumerable<TInner> inner, 
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector, 
            Func<TOuter, TInner, TResult> resultSelector)
        {
            Validate<IEnumerable<TOuter>>.NotNull(outer, nameof(outer));
            Validate<IEnumerable<TInner>>.NotNull(inner, nameof(inner));
            Validate<Func<TOuter, TKey>>.NotNull(outerKeySelector, nameof(outerKeySelector));
            Validate<Func<TInner, TKey>>.NotNull(innerKeySelector, nameof(innerKeySelector));
            Validate<Func<TOuter, TInner, TResult>>.NotNull(resultSelector, nameof(resultSelector));

            var comparer = EqualityComparer<TKey>.Default;

            foreach (var outerItem in outer)
            {
                var outerKey = outerKeySelector(outerItem);

                foreach (var innerItem in inner)
                {
                    var innerKey = innerKeySelector(innerItem);

                    if (comparer.Equals(outerKey, innerKey)) 
                        yield return resultSelector(outerItem, innerItem);
                }
            }
        }
    }
}