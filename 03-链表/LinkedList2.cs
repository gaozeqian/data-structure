using System.Text;

namespace _03_链表
{
    // 增加虚拟头节点
    public class LinkedList2<T> : AbstractList<T>
    {
        private Node<T> first;

        public LinkedList2()
        {
            first = new Node<T>(default, null);
        }

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
            var prev = index == 0 ? first : GetNode(index - 1);
            prev.next = new Node<T>(element, prev.next);

            size++;
        }

        public override T Remove(int index)
        {
            RangeCheck(index);

            var prev = index == 0 ? first : GetNode(index - 1);
            var node = prev.next;
            prev.next = node.next;
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
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var node = first.next;

            sb.Append($"size = {size}, [");
            for (int i = 0; i < size; i++)
            {
                if (i != 0)
                    sb.Append(",");

                sb.Append(node.element);
                node = node.next;
            }
            sb.Append("]");

            return sb.ToString();
        }

        private Node<T> GetNode(int index)
        {
            RangeCheck(index);

            var node = first.next;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }

            return node;
        }

        private class Node<E>
        {
            public E element;
            public Node<E> next;

            public Node(E element, Node<E> next)
            {
                this.element = element;
                this.next = next;
            }
        }
    }
}