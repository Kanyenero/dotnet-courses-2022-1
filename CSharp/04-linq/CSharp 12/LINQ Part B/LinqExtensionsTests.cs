using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTasksReinvent
{
    [TestFixture]
    public class LinqExtensionsTests
    {
        [Test]
        public void TestRepeat()
        {
            List<int> expected = new List<int>(new int[] { 1, 1, 1, 1, 1 });
            List<int> data = new List<int>(new int[] { 1 });

            var actual = data.Repeat(5);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestRepeat_ThrowsException()
        {
            List<int> data = new List<int>(new int[] { 1, 1 });

            Assert.Throws<ArgumentException>(() => data.Repeat(5).ToList());
        }

        [Test]
        public void TestConcat()
        {
            List<string> expected = new List<string>(new string[] { "a", "b", "c", "d", "e" });
            List<string> first = new List<string>(new string[] { "a", "b" });
            List<string> second = new List<string>(new string[] { "c", "d", "e" });

            var actual = first.Concat(second);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTake()
        {
            List<string> expected = new List<string>(new string[] { "a", "b" });
            List<string> data = new List<string>(new string[] { "a", "b", "c", "d", "e" });

            var actual = data.Take(2);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFirstOrDefault_ReturnDefault()
        {
            int expected = 0;
            List<int> data = new List<int>(new int[] { 0, 1, 2, 3, 4 });

            var actual = data.FirstOrDefault(d => d > 4);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFirstOrDefault_ReturnFirst()
        {
            string expected = "d";
            List<string> data = new List<string>(new string[] { "a", "b", "c", "d", "e" });

            var actual = data.FirstOrDefault(d => d == "d");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestToList()
        {
            List<int> data = new List<int>(new int[] { 1, 2, 3, 4 });

            var actual = data.ToList();

            Assert.AreEqual(typeof(List<int>), actual.GetType());
        }

        [Test]
        public void TestWhere()
        {
            List<int> expected = new List<int>(new[] { 0, 10 });
            List<int> data = new List<int>(new[] { 0, 20, 10, 40 });

            var actual = data.Where((d, index) => d <= index * 10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAny_ReturnTrue()
        {
            List<string> data = new List<string>(new[] { "a", "b", "c", "d", "e" });

            var actual = data.Any(d => d == "c");

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestAny_ReturnFalse()
        {
            List<string> data = new List<string>(new[] { "a", "b", "c", "d", "e" });

            var actual = data.Any(d => d == "z");

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestContains_ReturnTrue()
        {
            List<string> data = new List<string>(new[] { "a", "b", "c", "d", "e" });

            var actual = data.Contains("a", EqualityComparer<string>.Default);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestContains_ReturnFalse()
        {
            List<string> data = new List<string>(new[] { "a", "b", "c", "d", "e" });

            var actual = data.Contains("z", EqualityComparer<string>.Default);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestSelect()
        {
            List<int> expected = new List<int>(new[] { 0, 1, 4, 9, 16 });
            List<int> data = new List<int>(new[] { 0, 1, 2, 3, 4 });

            var actual = data.Select((d, index) => d * index);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSelectMany()
        {
            List<string> expected = new List<string>(new[]
            {
                "Scruffy",
                "Sam",
                "Walker",
                "Sugar",
                "Scratches",
                "Diesel"
            });
            var data = new[]
            {
                new  { Name="Higa, Sidney",
                    Pets = new List<string>{ "Scruffy", "Sam" } },
                new  { Name="Ashkenazi, Ronen",
                    Pets = new List<string>{ "Walker", "Sugar" } },
                new  { Name="Price, Vernette",
                    Pets = new List<string>{ "Scratches", "Diesel" } }
            };

            var actual = data.SelectMany(d => d.Pets);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAggregate()
        {
            string expected = "dog lazy the over jumps fox brown quick the";
            List<string> data = new List<string>(new[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" });

            var actual = data.Aggregate((d, next) => next + " " + d).Trim();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDistinct()
        {
            List<int> expected = new List<int>(new[] { 10, 20, 30 });
            List<int> data = new List<int>(new[] { 10, 20, 30, 20, 30 });

            var actual = data.Distinct();

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestIntersect()
        {
            List<int> expected = new List<int>(new[] { 40, 50 });
            List<int> first = new List<int>(new[] { 10, 20, 30, 40, 50 });
            List<int> second = new List<int>(new[] { 40, 50, 60, 70, 80 });

            var actual = first.Intersect(second);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestGroupBy()
        {
            List<string> expected = new List<string>(new[]
            {
                "int - 1, double - 1,3",
                "int - 2, double - 2,6",
                "int - 12, double - 12,1"
            });
            List<double> data = new List<double>(new[] { 1.3, 2.6, 12.1 });

            var actual = data.GroupBy(
                d => d,
                d => (int)Math.Floor(d),
                (real, integer) =>
                {
                    StringBuilder result = new StringBuilder();
                    result.Append("int - ");
                    foreach (int item in integer)
                    {
                        result.Append(item);
                    }

                    result.Append(string.Format(", double - {0}", real));

                    return result.ToString();
                });

            CollectionAssert.AreEqual(expected, actual);
        }

        class Person
        {
            public string Name { get; set; }
        }

        class Pet
        {
            public string Name { get; set; }
            public Person Owner { get; set; }
        }

        [Test]
        public void TestJoin()
        {
            var expected = new[]
            {
                new { OwnerName = "Hedlund, Magnus", Pet = "Daisy" },
                new { OwnerName = "Adams, Terry", Pet = "Barley"},
                new { OwnerName = "Adams, Terry", Pet = "Boots"},
                new { OwnerName = "Weiss, Charlotte" , Pet = "Whiskers"},
            };
            Person magnus = new Person { Name = "Hedlund, Magnus" };
            Person terry = new Person { Name = "Adams, Terry" };
            Person charlotte = new Person { Name = "Weiss, Charlotte" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            List<Person> people = new List<Person> { magnus, terry, charlotte };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, daisy };

            var actual =
                people.Join(pets,
                    person => person,
                    pet => pet.Owner,
                    (person, pet) =>
                        new { OwnerName = person.Name, Pet = pet.Name });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
