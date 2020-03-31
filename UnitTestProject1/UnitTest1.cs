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
            int expected = 8;
            int actual;
            //act
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Add(25);
            actual = list.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
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
        public void NewList_CheckOrder_Index2()
        {
            //arrange
            NewList<int> list = new NewList<int>();
            int expected = 15;
            int index = 2;
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

    }
}
