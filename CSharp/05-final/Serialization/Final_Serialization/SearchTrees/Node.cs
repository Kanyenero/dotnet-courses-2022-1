using System.Xml.Serialization;

namespace Task_11.SearchTrees
{
    [Serializable]
    public class Node<TData> : IComparable<TData> where TData : class, IComparable<TData>
    {
        public TData Data { get; set; }
        public Node<TData> ChildLeft { get; set; }
        public Node<TData> ChildRight { get; set; }

        [XmlIgnore]
        public bool HasLeftChild => ChildLeft != null;

        [XmlIgnore]
        public bool HasRightChild { get { return ChildRight != null; } }

        public Node() { }
        public Node(TData data)
        {
            Data = data;
        }

        public int CompareTo(TData? other)
        {
            return Data.CompareTo(other);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
