using System;

namespace Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrange
            NewList<int> list = new NewList<int>();
            //act
            list.Add(1);
            list.Add(8);
            list.Add(4);
            list.Add(7);
            list.Add(10);
            list.Add(3);
            list.Add(2);
            list.Add(11);
            list.Add(9);
            list.Add(5);
            list.Add(6);

            foreach (int nums in list)
            {
                Console.WriteLine(nums);
            }
            Console.ReadLine();
        }
    }
}
