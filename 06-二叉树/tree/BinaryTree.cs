using System.Collections.Generic;

namespace _06_二叉树.tree
{
    public class BinaryTree<T>
    {
        protected int size;
        protected Node<T> root;

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Clear()
        {
            root = null;
            size = 0;
        }

        public void Preorder(Visitor<T> visitor)
        {
            if (visitor == null) return;
            Preorder(root, visitor);
        }

        private void Preorder(Node<T> node, Visitor<T> visitor)
        {
            if (node == null || visitor.stop) return;

            visitor.stop = visitor.Visit(node.element);
            Preorder(node.left, visitor);
            Preorder(node.right, visitor);
        }

        public void Inorder(Visitor<T> visitor)
        {
            if (visitor == null) return;
            Inorder(root, visitor);
        }

        private void Inorder(Node<T> node, Visitor<T> visitor)
        {
            if (node == null || visitor.stop) return;

            Inorder(node.left, visitor);
            if (visitor.stop) return;
            visitor.stop = visitor.Visit(node.element);
            Inorder(node.right, visitor);
        }

        public void Postorder(Visitor<T> visitor)
        {
            if (visitor == null) return;
            Postorder(root, visitor);
        }

        private void Postorder(Node<T> node, Visitor<T> visitor)
        {
            if (node == null || visitor.stop) return;

            Postorder(node.left, visitor);
            Postorder(node.right, visitor);
            if (visitor.stop) return;
            visitor.stop = visitor.Visit(node.element);
        }

        public void LevelOrder(Visitor<T> visitor)
        {
            if (root == null || visitor == null) return;

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                if (visitor.Visit(node.element)) return;

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }

        public bool IsComplete()
        {
            if (root == null) return false;

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            bool isLeaf = false;
            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                if (isLeaf && !node.IsLeaf()) return false;

                if (node.left != null)
                    queue.Enqueue(node.left);
                else if (node.right != null)
                    return false;

                if (node.right != null)
                    queue.Enqueue(node.right);
                else
                    isLeaf = true; // 后面遍历的节点都必须是叶子节点
            }

            return true;
        }

        public int Height()
        {
            if (root == null) return 0;

            // 树的高度
            int height = 0;
            // 存储着每一层的元素数量
            int levelSize = 1;

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                levelSize--;

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);

                if (levelSize == 0)
                { // 即将访问下一层
                    levelSize = queue.Count;
                    height++;
                }
            }

            return height;
        }

        protected Node<T> CreateNode(T element, Node<T> parent)
        {
            return new Node<T>(element, parent);
        }

        protected Node<T> Predecessor(Node<T> node)
        {
            if (node == null) return null;

            // 前驱节点在左子树当中（left.right.right...）
            Node<T> pre = node.left;
            if (pre != null)
            {
                while (pre.right != null)
                    pre = pre.right;

                return pre;
            }

            // 从父节点、祖父节点中寻找前驱节点
            while (node.parent != null && node == node.parent.left)
                node = node.parent;

            return node.parent;
        }

        protected Node<T> Successor(Node<T> node)
        {
            if (node == null) return null;

            // 后继节点在右子树当中（right.left.left...）
            Node<T> post = node.right;
            if (post != null)
            {
                while (post.left != null)
                    post = post.left;

                return post;
            }

            // 从父节点、祖父节点中寻找后继节点
            while (node.parent != null && node == node.parent.right)
                node = node.parent;

            return node.parent;
        }

        public abstract class Visitor<T>
        {
            public bool stop;

            // return ture 停止遍历
            public abstract bool Visit(T element);
        }

        protected class Node<T>
        {
            public T element;
            public Node<T> left;
            public Node<T> right;
            public Node<T> parent;

            public Node(T element, Node<T> parent)
            {
                this.element = element;
                this.parent = parent;
            }

            public bool IsLeaf()
            {
                return left == null && right == null;
            }

            public bool HasTwoChildren()
            {
                return left != null && right != null;
            }

            public bool IsLeftChild()
            {
                return parent != null && this == parent.left;
            }

            public bool IsRightChild()
            {
                return parent != null && this == parent.right;
            }

            public Node<T> Sibling()
            {
                if (IsLeftChild()) return parent.right;
                if (IsRightChild()) return parent.left;
                return null;
            }
        }
    }
}