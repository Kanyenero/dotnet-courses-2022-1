using System.Collections;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Task_11.SearchTrees
{
    [Serializable]
    public abstract class BinarySearchTree<TItem> : IXmlSerializable, IEnumerable<TItem> where TItem : class, IComparable<TItem>
    {
        [XmlAttribute("NodeOfExam")]
        public Node<TItem> Root { get; protected set; }

        [XmlIgnore]
        public bool IsEmpty => Root == null;


        public BinarySearchTree() { }
        public BinarySearchTree(IEnumerable<TItem> collection)
        {
            AddRange(collection);
        }


        public abstract void Add(object obj);
        public abstract void Add(TItem data);
        public void AddRange(IEnumerable<TItem> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }


        public abstract Node<TItem> Find(TItem data);
        protected abstract Node<TItem> Find(TItem data, out Node<TItem> parent);


        public abstract IEnumerator<TItem> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public TItem GetMax()
        {
            CheckForNull(Root, nameof(Root), nameof(GetMax));
            return BinarySearchTree<TItem>.GetMostRight(Root).Data;
        }
        public TItem GetMin()
        {
            CheckForNull(Root, nameof(Root), nameof(GetMin));
            return BinarySearchTree<TItem>.GetMostLeft(Root).Data;
        }


        protected int Compare(TItem data, Node<TItem> node)
        {
            CheckForNull(data, nameof(data), nameof(Compare));
            CheckForNull(node, nameof(node), nameof(Compare));

            return data.CompareTo(node.Data);
        }


        public void Flush()
        {
            Remove(Root.Data);
        }
        public bool Remove(TItem data)
        {
            if (data == null) return false;

            var node = Find(data, out Node<TItem> parent);

            if (node == null) return false;

            if (node.HasLeftChild && node.HasRightChild)
            {
                RemoveNodeHavingBothChildren(node, parent);
                return true;
            }

            if (node.HasLeftChild || node.HasRightChild)
            {
                RemoveNodeHavingOneChild(node, parent);
                return true;
            }

            RemoveNodeHavingNoChildren(node, parent);
            return true;
        }
        private void RemoveNodeHavingNoChildren(Node<TItem> nodeToRemove, Node<TItem> parent)
        {
            if (nodeToRemove == Root)
            {
                Root = null;
            }
            else if (nodeToRemove == parent.ChildLeft)
            {
                parent.ChildLeft = null;
            }
            else if (nodeToRemove == parent.ChildRight)
            {
                parent.ChildRight = null;
            }
            else
            {
                throw new InvalidOperationException($"Node '{nameof(nodeToRemove)}' doesn't exist in the Binary Search Tree.");
            }
        }
        private void RemoveNodeHavingOneChild(Node<TItem> nodeToRemove, Node<TItem> parent)
        {
            if (nodeToRemove == Root)
            {
                if (nodeToRemove.HasLeftChild)
                {
                    Root = nodeToRemove.ChildLeft;
                }
                if (nodeToRemove.HasRightChild)
                {
                    Root = nodeToRemove.ChildRight;
                }
            }
            else if (nodeToRemove == parent.ChildLeft)
            {
                if (nodeToRemove.HasLeftChild)
                {
                    parent.ChildLeft = nodeToRemove.ChildLeft;
                }
                if (nodeToRemove.HasRightChild)
                {
                    parent.ChildLeft = nodeToRemove.ChildRight;
                }
            }
            else if (nodeToRemove == parent.ChildRight)
            {
                if (nodeToRemove.HasLeftChild)
                {
                    parent.ChildRight = nodeToRemove.ChildLeft;
                }
                if (nodeToRemove.HasRightChild)
                {
                    parent.ChildRight = nodeToRemove.ChildRight;
                }
            }
            else
            {
                throw new InvalidOperationException($"Node '{nameof(nodeToRemove)}' doesn't exist in the Binary Search Tree.");
            }

            nodeToRemove.ChildLeft = null;
            nodeToRemove.ChildRight = null;
            nodeToRemove = null;
        }
        private void RemoveNodeHavingBothChildren(Node<TItem> nodeToRemove, Node<TItem> parent)
        {
            var leftSubTree = nodeToRemove.ChildLeft;
            var rightSubTree = nodeToRemove.ChildRight;

            if (nodeToRemove == Root)
            {
                if (!rightSubTree.HasLeftChild)
                {
                    Root = rightSubTree;
                    Root.ChildLeft = leftSubTree;
                }
                else
                {
                    var mostLeft = BinarySearchTree<TItem>.GetMostLeft(rightSubTree, out Node<TItem> mostLeftParent);

                    if (mostLeft.HasRightChild)
                    {
                        mostLeftParent.ChildLeft = mostLeft.ChildRight;
                    }

                    Root = mostLeft;
                    Root.ChildLeft = leftSubTree;
                    Root.ChildRight = rightSubTree;
                }
            }
            else if (nodeToRemove == parent.ChildLeft)
            {
                var mostRight = BinarySearchTree<TItem>.GetMostRight(leftSubTree, out Node<TItem> mostRightParent);

                if (mostRight.HasLeftChild)
                {
                    mostRightParent.ChildRight = mostRight.ChildLeft;
                }

                parent.ChildLeft = mostRight;
                parent.ChildLeft.ChildLeft = leftSubTree;
                parent.ChildLeft.ChildRight = rightSubTree;
            }
            else if (nodeToRemove == parent.ChildRight)
            {
                var mostRight = BinarySearchTree<TItem>.GetMostRight(leftSubTree, out Node<TItem> mostRightParent);

                if (mostRight.HasLeftChild)
                {
                    mostRightParent.ChildRight = mostRight.ChildLeft;
                }

                parent.ChildRight = mostRight;
                parent.ChildRight.ChildLeft = leftSubTree;
                parent.ChildRight.ChildRight = rightSubTree;
            }
            else
            {
                throw new InvalidOperationException($"Node '{nameof(nodeToRemove)}' doesn't exist in the Binary Search Tree.");
            }

            nodeToRemove.ChildLeft = null;
            nodeToRemove.ChildRight = null;
            nodeToRemove = null;
        }


        protected static Node<TItem> GetMostLeft(Node<TItem> startNode)
        {
            var endNode = startNode;

            while (endNode.HasLeftChild)
            {
                endNode = endNode.ChildLeft;
            }

            return endNode;
        }
        protected static Node<TItem> GetMostRight(Node<TItem> startNode)
        {
            var endNode = startNode;

            while (endNode.HasRightChild)
            {
                endNode = endNode.ChildRight;
            }

            return endNode;
        }
        protected static Node<TItem> GetMostLeft(Node<TItem> startNode, out Node<TItem> parent)
        {
            parent = null;
            var endNode = startNode;

            while (endNode.HasLeftChild)
            {
                parent = endNode;
                endNode = endNode.ChildLeft;
            }

            return endNode;
        }
        protected static Node<TItem> GetMostRight(Node<TItem> startNode, out Node<TItem> parent)
        {
            parent = null;
            var endNode = startNode;

            while (endNode.HasRightChild)
            {
                parent = endNode;
                endNode = endNode.ChildRight;
            }

            return endNode;
        }


        protected static void CheckForNull(TItem data, string name, string methodName)
        {
            if (data == null)
            {
                throw new ArgumentNullException($"{methodName} exception! Argument '{name}' was null.");
            }
        }
        protected static void CheckForNull(Node<TItem> node, string name, string methodName)
        {
            if (node == null)
            {
                throw new ArgumentNullException($"{methodName} exception! Argument '{name}' was null.");
            }
        }

        public XmlSchema? GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var serializer = new XmlSerializer(typeof(Node<TItem>));
            reader.ReadStartElement();
            Root = (Node<TItem>)serializer.Deserialize(reader);
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            var serializer = new XmlSerializer(typeof(Node<TItem>));
            serializer.Serialize(writer, Root);
        }
    }
}
