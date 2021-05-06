using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_二叉树.tree
{
    public class BinarySearchTree<T> : BinaryTree<T>
    {
        private readonly Comparer<T> comparer;

        public BinarySearchTree() : this(null) { }

        public BinarySearchTree(Comparer<T> comparer)
        {
            this.comparer = comparer;
        }

        public void Add(T element)
        {
            ElementNotNullCheck(element);

            // 添加第一个节点
            if(root == null)
            {
                root = CreateNode(element, null);
                size++;

                // 新添加节点之后的处理
                AfterAdd(root);
                return;
            }

            // 添加的不是第一个节点
            // 找到父节点
            Node<T> parent = root;
            Node<T> node = root;
            int cmp = 0;
            do
            {
                cmp = Compare(element, node.element);
                parent = node;

                if (cmp > 0)
                    node = node.right;
                else if (cmp < 0)
                    node = node.left;
                else
                {
                    node.element = element;
                    return;
                }
            } while (node != null);


        }

        /// <summary>
        /// 添加node之后的调整
        /// </summary>
        /// <param name="node">新添加的节点</param>
        protected void AfterAdd(Node<T> node) { }

        /// <summary>
        /// 删除node之后的调整
        /// </summary>
        /// <param name="node">被删除的节点 或者 用以取代被删除节点的子节点（当被删除节点的度为1）</param>
        protected void AfterRemove(Node<T> node) { }

        private Node<T> Node(T element)
        {
            Node<T> node = root;
            while(node != null)
            {
                int cmp = Compare(element, node.element);
                if (cmp == 0)
                    return node;

                if (cmp > 0)
                    node = node.right;
                else
                    node = node.left;
            }
            return null;
        }

        // 返回值等于0，代表e1和e2相等；返回值大于0，代表e1大于e2；返回值小于于0，代表e1小于e2
        private int Compare(T e1, T e2)
        {
            if (comparer != null)
                return comparer.Compare(e1, e2);

            return ((IComparable<T>)e1).CompareTo(e2);
        }

        private void ElementNotNullCheck(T element)
        {
            if (element == null)
                throw new Exception("element must not be null");
        }
    }
}
