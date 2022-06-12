namespace Task_11.SearchTrees
{
    public class Node<TData> : IComparable<TData> where TData : class, IComparable<TData>
    {
        public TData Data { get; private set; }
        public Node<TData> ChildLeft { get; set; }
        public Node<TData> ChildRight { get; set; }

        public bool HasLeftChild { get { return ChildLeft != null; } }
        public bool HasRightChild { get { return ChildRight != null; } }

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
