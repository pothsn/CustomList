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
        public void Remove_RemoveItemFromEndOfList_CountDecrements()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            int expected = 3;
            int actual;

            //Act
            testList.Remove(444);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //TODO: Test that an exception was thrown if i is out of range
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_AttemptToRemoveItemFromOutOfRangeIndex_ExceptionThrownIsTrue()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);

            //Act
            testList.Remove(testList[4]);
        }

        [TestMethod]
        public void Remove_RemoveItemFromIndexWithinList_ItemsCloseGap()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            int expected = (444);

            //Act
            testList.Remove(333);
            int actual = testList[2];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemoveItemNoExists_NothingRemoved()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            int expected1 = 111;
            int expected2 = 222;
            int actual1;
            int actual2;

            //Act
            testList.Remove(1234);
            actual1 = testList[0];
            actual2 = testList[1];

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void Remove_RemoveItemNoExists_CountDidNotChange()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            int expected = 4;
            int actual;

            //Act
            testList.Remove(555);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemWhenAotherIndexHasSameValue_OnlyFirstRemoved()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(111);
            testList.Add(444);
            int expected = 111;
            int actual;

            //Act
            testList.Remove(111);
            actual = testList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemWhenAotherIndexHasSameValue_CountOnlyDecrementsByOne()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(111);
            testList.Add(444);
            int expected = 3;
            int actual;

            //Act
            testList.Remove(111);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
