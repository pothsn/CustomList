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

        private int capacity;
        public int Capacity
        {
            get => capacity;
        }



        //Constructor (is a)



        //Member methods (can do)
        public void Add(T newData)
        {
            if (capacity < 4)
            {
                if (count < 1)
                {
                    array[0] = newData;
                }
                else
                {
                    array[count + 1] = newData;
                }
            }
            else
            {
                //move data to larger array, increase capacity
            }
            count++;
        }
    }
}
