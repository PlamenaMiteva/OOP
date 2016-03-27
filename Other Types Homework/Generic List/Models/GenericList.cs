namespace Generic_List.Models
{
    using System;
    using System.Linq;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] array;
        private int index;
        private int currentCapacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.array = new T[capacity];
            this.currentCapacity = capacity;
            this.index = 0;
        }

        public void Add(T item)
        {
            if (this.index == this.currentCapacity)
            {
                this.Resize(this.currentCapacity * 2);
            }
            this.array[this.index] = item;
            this.index++;
        }

        public T this[int idx]
        {
            get { return this.array[idx]; }
        }

        public void Remove(int position)
        {
            if (position < 0 || position > index)
            {
                throw new IndexOutOfRangeException();
            }
            array = array.Where((val, idx) => idx != position).ToArray();
            this.index--;
        }

        public void Insert(T element, int position)
        {
            T[] newArray = new T[currentCapacity];
            int counter = 0;
            for (int i = 0; i < this.index; i++)
            {
                if (i != position)
                {
                    newArray[counter] = this.array[i];
                    counter++;
                }
                else
                {
                    newArray[position] = element;
                    newArray[counter + 1] = this.array[i];
                    counter += 2;
                }
            }
            this.array = newArray;
            this.index++;
        }

        public int? Find(T element)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (array[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }
            return null;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (array[i].CompareTo(element) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            this.array = null;
        }

        public T Max()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }
            T max = this.array[0];
            for (int i = 1; i < this.index; i++)
            {
                if (this.array[i].CompareTo(max) > 0)
                {
                    max = this.array[i];
                }
            }
            return max;
        }

        public T Min()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }
            T min = this.array[0];
            for (int i = 1; i < this.index; i++)
            {
                if (this.array[i].CompareTo(min) < 0)
                {
                    min = this.array[i];
                }
            }
            return min;
        }

        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < this.index; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
            this.currentCapacity = newCapacity;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < index; i++)
            {
                result.Append(array[i]);
                result.Append(" ");
            }
            return result.ToString();
        }
    }
}
