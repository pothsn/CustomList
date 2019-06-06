using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member variables (has a)
        T[] array = new T[4];

        public T this[int i]
        {
            get
            {
                if (i > count || i < 0)
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
                if (i > count || i < 0)
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
                for (int i = 0; i < count; i++ )
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
            for (int i = 0; i < count; i++)
            {
                if (targetData.Equals(array[i]))
                {
                    break;
                }
                temp[i] = array[i];
            }
            array = temp;
            count--;
        }
    }
}
