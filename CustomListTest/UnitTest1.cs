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
        public void Add_AddItemToPopulatedList_ItemGoesToIndexThree()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            int expected = 444;
            int actual;

            //Act
            testList.Add(444);
            actual = testList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToPopulatedList_CountIncrementsToFour()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            int expected = 4;
            int actual;

            //act
            testList.Add(444);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemOutOfArrayRange_ItemGoesToIndexFour()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            int expected = 555;
            int actual;

            //act
            testList.Add(555);
            actual = testList[4];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //initial array capacity 4
        [TestMethod]
        public void Add_AddItemOutOfArrayRange_CountStillIncrements()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            int expected = 5;
            int actual;

            //act
            testList.Add(555);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        






        //END ADD

        //BEGIN REMOVE
        [TestMethod]
        public void Remove_RemoveItemFromList_CountDecrements()
        {

        }
    }
}
