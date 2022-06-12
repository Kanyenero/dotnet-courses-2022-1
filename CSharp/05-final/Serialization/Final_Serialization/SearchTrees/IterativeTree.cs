namespace Task_11.SearchTrees
{
    public class IterativeTree<TItem> : BinarySearchTree<TItem> where TItem : class, IComparable<TItem>
    {
        public IterativeTree() : base() { }
        public IterativeTree(IEnumerable<TItem> collection) : base(collection) { }

        public override void Add(object obj)
        {
            throw new NotImplementedException();
        }
        public override void Add(TItem data)
        {
            CheckForNull(data, nameof(data), nameof(Add));

            Root = IterativeTree<TItem>.IterativeInsert(Root, data);
        }
        private static Node<TItem> IterativeInsert(Node<TItem> root, TItem data)
        {
            Node<TItem> node = root;
            Node<TItem> parent = null;

            if (root == null)
            {
                return new Node<TItem>(data);
            }

            while (node != null)
            {
                parent = node;

                if (node.CompareTo(data) > 0)
                {
                    node = node.ChildLeft;
                    continue;
                }
                if (node.CompareTo(data) < 0)
                {
                    node = node.ChildRight;
                    continue;
                }

                throw new InvalidOperationException($"{nameof(IterativeInsert)} exception! Passed parameter '{data}' already exists in Binary Search Three");
            }

            if (parent.CompareTo(data) > 0)
            {
                parent.ChildLeft = new Node<TItem>(data);
                return root;
            }
            if (parent.CompareTo(data) < 0)
            {
                parent.ChildRight = new Node<TItem>(data);
                return root;
            }

            return root;
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
            return IterativeSearch(Root, data, out parent);
        }
        private Node<TItem> IterativeSearch(Node<TItem> root, TItem data, out Node<TItem> foundedNodeParent)
        {
            foundedNodeParent = null;

            Node<TItem> node = root;
            Node<TItem> parent = null;

            while (node != null && !(node.CompareTo(data) == 0))
            {
                parent = node;

                if (node.CompareTo(data) > 0)
                {
                    node = node.ChildLeft;
                    continue;
                }
                if (node.CompareTo(data) < 0)
                {
                    node = node.ChildRight;
                    continue;
                }

                break;
            }

            if (node == null)
            {
                throw new InvalidOperationException($"{nameof(IterativeSearch)} exception! Key not found.");
            }

            foundedNodeParent = parent;
            return node;
        }


        public override IEnumerator<TItem> GetEnumerator()
        {
            return IterativeInOrderTraversal(Root).GetEnumerator();
        }

        private IEnumerable<TItem> IterativeInOrderTraversal(Node<TItem> node)
        {
            if (Root == null) yield break;

            var stack = new Stack<Node<TItem>>();

            while (stack.Count > 0 || node != null)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.ChildLeft;
                    continue;
                }

                node = stack.Pop();
                yield return node.Data;
                node = node.ChildRight;
            }
        }
    }
}
