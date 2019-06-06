using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(111);
            customList.Add(222);
            customList.Add(333);
            customList.Add(444);
            customList.Add(555);
        }
    }
}
