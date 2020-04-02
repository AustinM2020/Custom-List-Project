using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void NewList_CheckCount_AddPositiveInt()
        {
            //arrange
            int numberToAdd = 5;
            int expected = 1;
            int actual;
            NewList<int> list = new NewList<int>();
            //act
            list.Add(numberToAdd);
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckIndex_Index0()
        {
            //arrange
            int numberToAdd = 5;
            int index = 0;
            int expected = 5;
            int actual;
            NewList<int> list = new NewList<int>();
            //act
            list.Add(numberToAdd);
            actual = list[index];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckCount_AddString()
        {
            //arrange
            string stringToAdd = "Charles";
            int expected = 1;
            int actual;
            NewList<string> list = new NewList<string>();
            //act
            list.Add(stringToAdd);
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewListString_CheckIndex_Index0()
        {
            //arrange
            string stringToAdd = "Charles";
            int index = 0;
            string expected = "Charles";
            string actual;
            NewList<string> list = new NewList<string>();
            //act
            list.Add(stringToAdd);
            actual = list[index];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckCapacity()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int expected = 16;
            int actual;
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
            actual = list.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckOrder_Index0()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int expected = 5;
            int index = 0;
            int actual;
            //act
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Add(25);
            actual = list[index];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckOrder_Index10()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int expected = 55;
            int index = 10;
            int actual;
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
            actual = list[index];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckOrder_Index4()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int expected = 25;
            int index = 4;
            int actual;
            //act
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Add(25);
            actual = list[index];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckRemoved_Index2()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int numberRemoved = 15;
            int index = 2;
            int expected = 20;
            int actual;
            //act
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Remove(numberRemoved);
            actual = list[index];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckCount_Remove15()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int numberRemoved = 15;
            int expected = 3;
            int actual;
            //act
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Remove(numberRemoved);
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckOrder_Remove45()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int numberRemoved = 45;
            int index = 8;
            int expected = 55;
            int actual;
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
            list.Remove(45);
            list.Remove(70);
            list.Remove(30);
            actual = list[index];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckCount_Remove45()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int expected = 8;
            int actual;
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
            list.Remove(45);
            list.Remove(20);
            list.Remove(30);
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckCount_RemoveString()
        {
            //arrange
            NewList<string> list = new NewList<string>();
            int expected = 2;
            int actual;
            //act
            list.Add("Charles");
            list.Add("King");
            list.Add("Mangos");
            list.Remove("King");
            actual = list.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckString_IntsToString()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            string expected = "5, 10, 15";
            string actual;
            //act
            list.Add(5);
            list.Add(10);
            list.Add(15);
            actual = list.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckString_StringToString()
        {
            //arrange
            NewList<string> list = new NewList<string>();
            string expected = "Charles, King, Mangos";
            string actual;
            //act
            list.Add("Charles");
            list.Add("King");
            list.Add("Mangos");
            actual = list.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckString_IntsToStringRemoved()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            string expected = "5, 15, 20, 25, 30, 40, 45, 10";
            string actual;
            //act
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Add(25);
            list.Add(30);
            list.Add(35);
            list.Add(40);
            list.Remove(35);
            list.Add(45);
            list.Remove(10);
            list.Add(10);
            actual = list.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckCombinedList_Operator()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            string expected = "1, 3, 5, 2, 4, 6";
            string actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            two.Add(2);
            two.Add(4);
            two.Add(6);
            NewList<int> three = one + two;
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckListOne_Count()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            int expected = 3;
            int actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            two.Add(2);
            two.Add(4);
            two.Add(6);
            actual = one.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckListThree_Count()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            int expected = 6;
            int actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            two.Add(2);
            two.Add(4);
            two.Add(6);
            NewList<int> three = one + two;
            actual = three.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckCombinedList2_Operator()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            string expected = "1, 3, 5, 7, 9, 2, 4, 6, 8, 10";
            string actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            one.Add(7);
            one.Add(9);
            two.Add(2);
            two.Add(4);
            two.Add(6);
            two.Add(8);
            two.Add(10);
            NewList<int> three = one + two;
            actual = three.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_CheckCombinedList3_Operator()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            string expected = "1, 3, 5, 9, 2, 4, 6, 10";
            string actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            one.Add(7);
            one.Add(9);
            two.Add(2);
            two.Add(4);
            two.Add(6);
            two.Add(8);
            two.Add(10);
            one.Remove(7);
            two.Remove(8);
            NewList<int> three = one + two;
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_SubtractedList_Operator()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            string expected = "3, 5";
            string actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            two.Add(2);
            two.Add(1);
            two.Add(6);
            NewList<int> three = one - two;
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_SubtractedList2_Operator()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            string expected = "5";
            string actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            one.Add(6);
            one.Add(8);

            two.Add(2);
            two.Add(1);
            two.Add(6);
            two.Add(11);
            two.Add(7);
            two.Add(8);
            two.Add(3);
            NewList<int> three = one - two;
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_SubtractedListOneCount_Operator()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            int expected = 5;
            int actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            one.Add(6);
            one.Add(8);
            two.Add(2);
            two.Add(1);
            two.Add(6);
            two.Add(11);
            two.Add(7);
            two.Add(8);
            two.Add(3);
            NewList<int> three = one - two;
            actual = one.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_SubtractedListTwoCount_Operator()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            int expected = 7;
            int actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            one.Add(6);
            one.Add(8);
            two.Add(2);
            two.Add(1);
            two.Add(6);
            two.Add(11);
            two.Add(7);
            two.Add(8);
            two.Add(3);
            NewList<int> three = one - two;
            actual = two.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_SubtractedListThreeCount_Operator()
        {
            NewList<int> one = new NewList<int>();
            NewList<int> two = new NewList<int>();
            int expected = 1;
            int actual;

            one.Add(1);
            one.Add(3);
            one.Add(5);
            one.Add(6);
            one.Add(8);
            two.Add(2);
            two.Add(1);
            two.Add(6);
            two.Add(11);
            two.Add(7);
            two.Add(8);
            two.Add(3);
            NewList<int> three = one - two;
            actual = three.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_ZipLists_OddsEvens()
        {
            NewList<int> odd = new NewList<int>();
            NewList<int> even = new NewList<int>();
            string expected = "1, 2, 3, 4, 5, 6";
            string actual;

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            NewList<int> three = odd.Zip(even);
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_ZipLists_EvensOdds()
        {
            NewList<int> odd = new NewList<int>();
            NewList<int> even = new NewList<int>();
            string expected = "2, 1, 4, 3, 6, 5";
            string actual;

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            NewList<int> three = even.Zip(odd);
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_ZipLists_EvenListIsLonger()
        {
            NewList<int> odd = new NewList<int>();
            NewList<int> even = new NewList<int>();
            string expected = "1, 2, 3, 4, 5, 6, 8, 10, 12, 14";
            string actual;

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            even.Add(8);
            even.Add(10);
            even.Add(12);
            even.Add(14);
            NewList<int> three = odd.Zip(even);
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_ZipLists_OddListIsLonger()
        {
            NewList<int> odd = new NewList<int>();
            NewList<int> even = new NewList<int>();
            string expected = "1, 2, 3, 4, 5, 6, 7, 9, 11, 13";
            string actual;

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            odd.Add(7);
            odd.Add(9);
            odd.Add(11);
            odd.Add(13);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            NewList<int> three = odd.Zip(even);
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewList_ZipLists_LongerLists()
        {
            NewList<int> odd = new NewList<int>();
            NewList<int> even = new NewList<int>();
            string expected = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14";
            string actual;

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            odd.Add(7);
            odd.Add(9);
            odd.Add(11);
            odd.Add(13);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            even.Add(8);
            even.Add(10);
            even.Add(12);
            even.Add(14);
            NewList<int> three = odd.Zip(even);
            actual = three.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
