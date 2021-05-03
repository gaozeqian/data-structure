using System;

namespace _03_双向循环列表
{
    public abstract class AbstractList<T>
    {
        protected int size;
        protected const int ELEMENT_NOT_FOUND = -1;

        public abstract T Get(int index);

        public abstract T Set(int index, T element);

        public abstract void Add(int index, T element);

        public abstract T Remove(int index);

        public abstract int IndexOf(T element);

        public abstract void Clear();

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

        protected void OutOfRange()
        {
            throw new IndexOutOfRangeException();
        }

        protected void RangeCheck(int index)
        {
            if (index < 0 || index >= size)
                OutOfRange();
        }

        protected void RangeCheckForAdd(int index)
        {
            if (index < 0 || index > size)
                OutOfRange();
        }
    }
}