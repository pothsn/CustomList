using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        //BEGIN ADD
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;
            // act
            testList.Add(expected);
            actual = testList[0];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;
            // act
            testList.Add(698);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // ADDITIONAL TEST IDEA:
        // If we add an item to a list that already has 5 things in it,
        // does the newly added item go to the correct spot? (index 5?)

        [TestMethod]
        public void Add_AddItemToPopulatedList_ItemGoesToIndexFive()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            testList.Add(555);
            int expected = 666;
            int actual;

            //Act
            testList.Add(666);
            actual = testList[5];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToPopulatedList_CountIncrementsToSix()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            testList.Add(555);
            int expected = 6;
            int actual;

            //act
            testList.Add(666);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Add_AddItemOutOfArrayRange_CountStillIncrements()
        //{
        //    //arrange
        //    CustomList<int> testList = new CustomList<int>();
        //    testList.Add(111);
        //    testList.Add(222);
        //    testList.Add(333);
        //    testList.Add(444);
        //    testList.Add(555);
        //    int expected = 6;
        //    int actual;

        //    //act
        //    testListAdd(666);
        //    actual = testList.Count;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}






        //END ADD

        //BEGIN REMOVE
        [TestMethod]
        public void Remove_RemoveItemFromList_CountDecrements()
        {

        }
    }
}
