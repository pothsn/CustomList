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
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            Console.WriteLine(testList.ToString());
        }
    }
}
