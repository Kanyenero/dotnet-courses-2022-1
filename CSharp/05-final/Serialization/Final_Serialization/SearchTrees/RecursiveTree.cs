namespace Task_11.SearchTrees
{
    [Serializable]
    public class RecursiveTree<TItem> : BinarySearchTree<TItem> where TItem : class, IComparable<TItem>
    {
        public RecursiveTree() : base() { }
        public RecursiveTree(IEnumerable<TItem> collection) : base(collection) { }

        public override void Add(object obj)
        {
            Add(obj as TItem);
        }
        public override void Add(TItem data)
        {
            CheckForNull(data, nameof(data), nameof(Add));

            Root = RecursiveInsert(Root, data);
        }
        private static Node<TItem> RecursiveInsert(Node<TItem> root, TItem data)
        {
            if (root == null)
            {
                return new Node<TItem>(data);
            }
            if (root.CompareTo(data) > 0)
            {
                root.ChildLeft = RecursiveInsert(root.ChildLeft, data);
                return root;
            }
            if (root.CompareTo(data) < 0)
            {
                root.ChildRight = RecursiveInsert(root.ChildRight, data);
                return root;
            }

            throw new InvalidOperationException($"{nameof(RecursiveInsert)} exception! Passed parameter '{data}' already exists in Binary Search Three");
        }


        public override Node<TItem> Find(TItem data)
        {
            CheckForNull(data, nameof(data), nameof(Find));

            if (IsEmpty)
            {
                throw new InvalidOperationException($"{nameof(Find)} exception! Binary Search Tree is empty.");
            }

            return Find(data, out Node<TItem> parent);
        }
        protected override Node<TItem> Find(TItem data, out Node<TItem> parent)
        {
            return RecursiveSearch(Root, data, null, out parent);
        }
        private Node<TItem> RecursiveSearch(Node<TItem> root, TItem data, Node<TItem> parent, out Node<TItem> foundedNodeParent)
        {
            foundedNodeParent = null;

            if (root == null)
            {
                throw new InvalidOperationException($"{nameof(RecursiveSearch)} exception! Key not found.");
            }
            if (root.CompareTo(data) > 0)
            {
                return RecursiveSearch(root.ChildLeft, data, root, out foundedNodeParent);
            }
            if (root.CompareTo(data) < 0)
            {
                return RecursiveSearch(root.ChildRight, data, root, out foundedNodeParent);
            }
            if (root.CompareTo(data) == 0)
            {
                foundedNodeParent = parent;
                return root;
            }

            return null;
        }


        public override IEnumerator<TItem> GetEnumerator()
        {
            return RecursiveInOrderTraversal(Root).GetEnumerator();
        }

        private IEnumerable<TItem> RecursiveInOrderTraversal(Node<TItem> node)
        {
            if (node == null) yield break;

            if (node.HasLeftChild)
            {
                foreach (var leftNodeData in RecursiveInOrderTraversal(node.ChildLeft))
                {
                    yield return leftNodeData;
                }
            }

            yield return node.Data;

            if (node.HasRightChild)
            {
                foreach (var rightNodeData in RecursiveInOrderTraversal(node.ChildRight))
                {
                    yield return rightNodeData;
                }
            }
        }
    }
}
