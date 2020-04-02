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
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Add(25);
            list.Add(30);
            list.Add(35);
            list.Add(40);
            list.Add(45);
            list.Add(50);
            list.Add(55);

            foreach (int nums in list)
            {
                Console.WriteLine(nums);
            }
            Console.ReadLine();
        }
    }
}
