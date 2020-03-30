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
            int numberToAdd = 5;
            int expected = 1;
            int actual;
            NewList<int> list = new NewList<int>();
            list.Add(numberToAdd);
            actual = list.Count;
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void NewList_CheckIndex_Index0()
        //{
        //    int index = 0;
        //    int expected = 5;
        //    int actual;
        //    NewList<int> list = new NewList<int>();
        //    actual = list[index];
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void NewList_CheckCount_AddString()
        //{
        //    string stringToAdd = "Charles";
        //    int expected = 1;
        //    int actual;
        //    NewList<string> list = new NewList<string>();
        //    actual = list.Count();
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void NewListString_CheckIndex_Index0()
        //{
        //    int index = 0;
        //    string expected = "Charles";
        //    string actual;
        //    NewList<string> list = new NewList<string>();
        //    actual = list[index];
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void NewList_CheckCapacity()
        //{
        //    NewList<string> list = new NewList<string>();
        //    int expected = 8;
        //    int actual;
        //    list.Add();
        //    list.Add();
        //    list.Add();
        //    list.Add();
        //    list.Add();
        //    actual = list.Capacity;
        //    Assert.AreEqual(expected, actual);
        //}

    }
}
