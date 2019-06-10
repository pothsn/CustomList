using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {
        //Member variables (has a)
        T[] array = new T[4];

        public T this[int i]
        {
            get
            {
                if (i >= count || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return array[i];
            }
            set
            {
                if (i < count)
                {
                    array[i] = value;
                }
                if (i >= count || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private int count;
        public int Count
        {
            get => count;
        }

        private int capacity = 4;
        public int Capacity
        {
            get => capacity;
        }

        //Constructor (is a)

        //Member methods (can do)
        public void Add(T data)
        {
            if (count < capacity)
            {
                array[count] = data;
            }
            if (count == capacity)
            {
                capacity = (capacity * 2);
                T[] temp = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = array[i];
                }
                temp[count] = data;
                array = temp;
            }
            count++;
        }

        public void Remove(T targetData)
        {
            T[] temp = new T[capacity];
            bool itemWasRemoved = false;

            for (int i = 0; i < count; i++)
            {
                if (!targetData.Equals(array[i]) && itemWasRemoved == false)
                {
                    temp[i] = array[i];
                }
                else
                {
                    itemWasRemoved = true;
                    if (i == count - 1)
                    {
                        temp[i] = default(T);

                    }
                    else
                    {
                        temp[i] = array[i + 1];
                    }
                }
            }
            if (itemWasRemoved)
            {
                count--;
                array = temp;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    sb.Append(array[i]);
                }
                else
                {
                    sb.Append(array[i]);
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> combinedList = new CustomList<T>();
            for (int i = 0; i < List1.Count; i++)
            {
                combinedList.Add(List1[i]);
            }
            for (int i = 0; i < List2.Count; i++)
            {
                combinedList.Add(List2[i]);
            }
            return combinedList;
        }

        public static CustomList<T> operator -(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> combinedList = new CustomList<T>();
            for (int i = 0; i < List1.Count; i++)
            {
                combinedList.Add(List1[i]);
            }
            for (int i = 0; i < List2.Count; i++)
            {
                for (i = 0; i < List1.Count; i++)
                {
                    if (!List1[i].Equals(List2[i]))
                    {
                        combinedList.Add(List2[i]);
                    }
                }             
            }
            return combinedList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
