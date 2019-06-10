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
        T[] array;

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
                if (i < count && i >= 0)
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

        private int capacity;
        public int Capacity
        {
            get => capacity;
        }

        //Constructor (is a)
        public CustomList()
        {
            count = 0;
            capacity = 4;
            array = new T[capacity];
        }

        //Member methods (can do)
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
                sb.Append(array[i]);
                if (i != count - 1)
                {
                    sb.Append(", ");
                }
                
            }
            return sb.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> combinedList = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                combinedList.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                combinedList.Add(list2[i]);
            }
            return combinedList;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> combinedList = new CustomList<T>();
            bool dataIsRepeated = false;
            foreach (T data in list1)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    if (data.Equals(list2[i]))
                    {
                        dataIsRepeated = true;
                    }
                }
                if (dataIsRepeated == false)
                {
                    combinedList.Add(data);
                }
                dataIsRepeated = false;
            }
            foreach (T data in list2) 
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if (data.Equals(list1[i]))
                    {
                        dataIsRepeated = true;
                    }
                }
                if (dataIsRepeated == false)
                {
                    combinedList.Add(data);
                }
                dataIsRepeated = false;
            }
            return combinedList;
        }

        public static CustomList<T> Zip(CustomList<T> list1, CustomList<T>list2)
        {
            CustomList<T> combinedList = new CustomList<T>();
            if (list1.count >= list2.count)
            {
                for (int i = 0; i < list1.count; i++)
                {
                    combinedList.Add(list1[i]);
                    if (i < list2.count)
                    {
                        combinedList.Add(list2[i]);
                    }
                }
            }
            if (list1.count < list2.count)
            {
                for (int i = 0; i < list2.count; i++)
                {                    
                    if (i < list1.count)
                    {
                        combinedList.Add(list1[i]);                        
                    }
                    combinedList.Add(list2[i]);
                }
            }
            return combinedList;
        }
    }
}
