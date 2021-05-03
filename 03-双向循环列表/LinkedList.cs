using System.Text;

namespace _03_双向循环列表
{
    public class LinkedList<T> : AbstractList<T>
    {
        private Node<T> first;
        private Node<T> last;

        public override T Get(int index)
        {
            return GetNode(index).element;
        }

        public override T Set(int index, T element)
        {
            var node = GetNode(index);
            var old = node.element;
            node.element = element;
            return old;
        }

        public override void Add(int index, T element)
        {
            if (index == size)
            {
                last = new Node<T>(element, last, first);
                if (last.prev == null)
                {
                    first = last;
                    first.next = first;
                    first.prev = first;
                }
                else
                {
                    last.prev.next = last;
                    first.prev = last;
                }
            }
            else
            {
                var next = GetNode(index);
                var prev = next.prev;
                var node = new Node<T>(element, prev, next);
                next.prev = node;
                prev.next = node;

                if (index == 0)
                    first = node;
            }

            size++;
        }

        public override T Remove(int index)
        {
            Node<T> node;
            if (size == 1)
            {
                node = first;
                first = null;
                last = null;
            }
            else
            {
                node = GetNode(index);
                node.prev.next = node.next;
                node.next.prev = node.prev;

                if (node == first)
                    first = node.next;

                if (node == last)
                    last = node.prev;
            }

            size--;

            return node.element;
        }

        public override int IndexOf(T element)
        {
            var node = first;

            if (element == null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (node.element == null)
                        return i;

                    node = node.next;
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (element.Equals(node.element))
                        return i;

                    node = node.next;
                }
            }

            return ELEMENT_NOT_FOUND;
        }

        public override void Clear()
        {
            size = 0;
            first = null;
            last = null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var node = first;

            sb.Append($"size = {size}, [");
            for (int i = 0; i < size; i++)
            {
                if (i != 0)
                    sb.Append(",");

                sb.Append(node);
                node = node.next;
            }
            sb.Append("]");

            return sb.ToString();
        }

        private Node<T> GetNode(int index)
        {
            RangeCheck(index);

            Node<T> node;
            if (index < size >> 1)
            {
                node = first;
                for (int i = 0; i < index; i++)
                    node = node.next;
            }
            else
            {
                node = last;
                for (int i = size - 1; i > index; i--)
                    node = node.prev;
            }

            return node;
        }

        private class Node<E>
        {
            public E element;
            public Node<E> prev;
            public Node<E> next;

            public Node(E element, Node<E> prev, Node<E> next)
            {
                this.element = element;
                this.prev = prev;
                this.next = next;
            }

            public override string ToString()
            {
                var sb = new StringBuilder();

                if (prev != null)
                    sb.Append(prev.element);
                else
                    sb.Append("null");

                sb.Append($"_{element}_");

                if (next != null)
                    sb.Append(next.element);
                else
                    sb.Append("null");

                return sb.ToString();
            }
        }
    }
}