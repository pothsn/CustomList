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

        private int count;
        public int Count
        {
            get => count;
            set => count = value;
        }

        private int capacity = 4;
        public int Capacity
        {
            get => capacity;
        }



        //Constructor (is a)



        //Member methods (can do)
        public void Add(T newData)
        {
            if (count < capacity)
            {
                array[count] = newData;
            }
            if (count == capacity)
            {
                capacity = (capacity * 2);
                T[] biggerArray = new T[capacity];
                for (int i = 0; i < count; i++ )
                {
                    T[] temp = new T[capacity];
                    temp[i] = array[i];
                    array[i] = biggerArray[i];
                    biggerArray[i] = temp[i];
                }
                biggerArray[count] = newData;
                array = biggerArray;
            }
            count++;
        }
    }
}
