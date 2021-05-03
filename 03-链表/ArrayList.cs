using System.Text;

namespace _03_链表
{
    public class ArrayList<T> : AbstractList<T>
    {
        private T[] elements;
        private const int DEFAULT_CAPACITY = 10;

        public ArrayList() : this(DEFAULT_CAPACITY)
        {

        }

        public ArrayList(int capacity)
        {
            capacity = capacity < DEFAULT_CAPACITY ? DEFAULT_CAPACITY : capacity;
            elements = new T[capacity];
        }

        public override T Get(int index)
        {
            RangeCheck(index);
            return elements[index];
        }

        public override T Set(int index, T element)
        {
            RangeCheck(index);
            var oldElement = elements[index];
            elements[index] = element;
            return oldElement;
        }

        public override void Add(int index, T element)
        {
            RangeCheckForAdd(index);
            EnsureCapacity(size + 1);

            for (int i = size; i > index; i--)
                elements[i] = elements[i - 1];

            elements[index] = element;
            size++;
        }

        public override T Remove(int index)
        {
            RangeCheck(index);
            var old = elements[index];

            for (int i = index + 1; i < size; i++)
                elements[i - 1] = elements[i];

            elements[--size] = default;
            TrimArray();

            return old;
        }

        public override int IndexOf(T element)
        {
            if (element == null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (elements[i] == null)
                        return i;
                }
            }
            else
            {
                for (var i = 0; i < size; i++)
                {
                    if (element.Equals(elements[i]))
                        return i;
                }
            }

            return ELEMENT_NOT_FOUND;
        }

        public override void Clear()
        {
            for (int i = 0; i < size; i++)
                elements[i] = default;

            size = 0;
            
            if (elements != null && elements.Length > DEFAULT_CAPACITY)
                elements = new T[DEFAULT_CAPACITY];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"size = {size}, [");
            for (int i = 0; i < size; i++)
            {
                if (i != 0)
                    sb.Append(",");

                sb.Append(elements[i]);
            }
            sb.Append("]");

            return sb.ToString();
        }

        private void EnsureCapacity(int capacity)
        {
            int oldCapacity = elements.Length;
            if (capacity > oldCapacity)
            {
                //扩容1.5倍
                int newCapacity = oldCapacity + oldCapacity >> 1;
                T[] newElements = new T[newCapacity];

                for (int i = 0; i < size; i++)
                    newElements[i] = elements[i];

                elements = newElements;
            }
        }

        private void TrimArray()
        {
            int capacity = elements.Length;
            int newCapacity = capacity >> 1;
            if (size >= newCapacity || capacity <= DEFAULT_CAPACITY)
                return;

            T[] newElements = new T[newCapacity];
            for (int i = 0; i < size; i++)
                newElements[i] = elements[i];

            elements = newElements;
        }
    }
}