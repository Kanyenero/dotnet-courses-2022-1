using Task_11.SearchTrees;

namespace DotNetCourse.CarRental.DataAccess
{
    public class XmlSerializer : ISerializer
    {
        public string OutputFilePath
        {
            get;
            set;
        }

        public XmlSerializer(string outputFilePath)
        {
            OutputFilePath = outputFilePath;
        }

        public bool TrySerializeCollection<TItem>(IEnumerable<TItem> collection)
            where TItem : class, IComparable<TItem>
        {
            var recursiveSearchTree = new RecursiveTree<TItem>(collection);

            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RecursiveTree<TItem>));

            try
            {
                using var fileStream = new FileStream(OutputFilePath, FileMode.Create);

                try
                {
                    xmlSerializer.Serialize(fileStream, recursiveSearchTree);
                }
                catch (InvalidOperationException)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
