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
    }
}
