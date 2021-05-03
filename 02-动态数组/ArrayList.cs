using System;
using System.Text;

namespace _02_动态数组
{
    public class ArrayList<T>
    {
        private int size;
        private T[] elements;
        private const int DEFAULT_CAPACITY = 10;
        private const int ELEMENT_NOT_FOUND = -1;

        public ArrayList() : this(DEFAULT_CAPACITY)
        {

        }

        public ArrayList(int capacity)
        {
            capacity = capacity < DEFAULT_CAPACITY ? DEFAULT_CAPACITY : capacity;
            elements = new T[capacity];
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool Contains(T element)
        {
            return IndexOf(element) != ELEMENT_NOT_FOUND;
        }

        public void Add(T element)
        {
            Add(size, element);
        }

        public T Get(int index)
        {
            RangeCheck(index);
            return elements[index];
        }

        public T Set(int index, T element)
        {
            RangeCheck(index);
            var oldElement = elements[index];
            elements[index] = element;
            return oldElement;
        }

        public void Add(int index, T element)
        {
            RangeCheckForAdd(index);
            EnsureCapacity(size + 1);

            for (int i = size; i > index; i--)
                elements[i] = elements[i - 1];

            elements[index] = element;
            size++;
        }

        public T Remove(int index)
        {
            RangeCheck(index);
            var old = elements[index];

            for (int i = index + 1; i < size; i++)
                elements[i - 1] = elements[i];

            elements[--size] = default;
            return old;
        }

        public int IndexOf(T element)
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

        public void Clear()
        {
            for (int i = 0; i < size; i++)
                elements[i] = default;

            size = 0;
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

        private void OutOfRange()
        {
            throw new IndexOutOfRangeException();
        }

        private void RangeCheck(int index)
        {
            if (index < 0 || index >= size)
                OutOfRange();
        }

        private void RangeCheckForAdd(int index)
        {
            if (index < 0 || index > size)
                OutOfRange();
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
    }
}