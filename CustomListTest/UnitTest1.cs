using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        //BEGIN Add
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
        //END Add

        //BEGIN Remove
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
        //END Remove

        //BEGIN ToString override
        [TestMethod]
        public void ToString_ConvertListToString_StringHasCorrectValues()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            string expected = "111, 222, 333, 444";
            string actual;

            //Act
            actual = testList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertEmptyListToString_StringIsEmpty()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "";
            string actual;

            //Act
            actual = testList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertBiggerListToString_StringHasCorrectValues()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(111);
            testList.Add(222);
            testList.Add(333);
            testList.Add(444);
            testList.Add(555);
            testList.Add(666);
            testList.Add(777);
            testList.Add(888);
            string expected = "111, 222, 333, 444, 555, 666, 777, 888";
            string actual;

            //Act
            actual = testList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //END ToString override

        //BEGIN overload +
        [TestMethod]
        public void ConcatLists_AddTwoListsTogether_StringHasCorrectValues()
        {
            //Arrange
            CustomList<int> testListOne = new CustomList<int>();
            testListOne.Add(111);
            testListOne.Add(222);
            testListOne.Add(333);
            testListOne.Add(444);
            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(555);
            testListTwo.Add(666);
            testListTwo.Add(777);
            testListTwo.Add(888);
            string expected = "111, 222, 333, 444, 555, 666, 777, 888";
            string actual;

            //Act
            CustomList<int> result = testListOne + testListTwo;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConCatLists_AddTwoListsTogether_StringHasCorrectCount()
        {
            //Arrange
            CustomList<int> testListOne = new CustomList<int>();
            testListOne.Add(111);
            testListOne.Add(222);
            testListOne.Add(333);
            testListOne.Add(444);
            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(555);
            testListTwo.Add(666);
            testListTwo.Add(777);
            testListTwo.Add(888);
            int expected = 8;
            int actual;

            //Act
            CustomList<int> result = testListOne + testListTwo;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConCatLists_AddThreeListsTogether_StringHasCorrectCount()
        {
            //Arrange
            CustomList<int> testListOne = new CustomList<int>();
            testListOne.Add(111);
            testListOne.Add(222);
            testListOne.Add(333);
            testListOne.Add(444);
            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(555);
            testListTwo.Add(666);
            testListTwo.Add(777);
            testListTwo.Add(888);
            CustomList<int> testListThree = new CustomList<int>();
            testListTwo.Add(555);
            testListTwo.Add(666);
            testListTwo.Add(777);
            testListTwo.Add(888);
            int expected = 12;
            int actual;

            //Act
            CustomList<int> result = testListOne + testListTwo + testListThree;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //END overload +

        //BEGIN overload -
        [TestMethod]
        public void SubtractLists_SubtractOneListFromAnother_ListHasCorrectValues()
        {
            //Arrange
            CustomList<int> testListOne = new CustomList<int>();
            testListOne.Add(111);
            testListOne.Add(222);
            testListOne.Add(333);
            testListOne.Add(444);
            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(111);
            testListTwo.Add(232);
            testListTwo.Add(333);
            testListTwo.Add(454);
            string expected = "222, 444, 232, 454";
            string actual;

            //Act
            CustomList<int> result = testListOne - testListTwo;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);     
        }

        [TestMethod]
        public void SubtractLists_SubrtactOneListFromAnother_ListHasCorrectCount()
        {
            //Arrange
            CustomList<int> testListOne = new CustomList<int>();
            testListOne.Add(111);
            testListOne.Add(222);
            testListOne.Add(333);
            testListOne.Add(444);
            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(333);
            testListTwo.Add(232);
            testListTwo.Add(444);
            testListTwo.Add(434);
            int expected = 4;
            int actual;

            //Act
            CustomList<int> result = testListOne - testListTwo;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractLists_SubtractThreeLists_ListHasCorrectValues()
        {
            //Arrange
            CustomList<int> testListOne = new CustomList<int>();
            testListOne.Add(111);
            testListOne.Add(121);
            testListOne.Add(444);
            testListOne.Add(333);
            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(222);
            testListTwo.Add(111);
            testListTwo.Add(232);
            testListTwo.Add(444);
            CustomList<int> testListThree = new CustomList<int>();
            testListTwo.Add(333);
            testListTwo.Add(444);
            testListTwo.Add(111);
            testListTwo.Add(343);
            string expected = "121, 222, 232, 343";
            string actual;
                       
            //Act
            CustomList<int> result = testListOne - testListTwo - testListThree;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //END overload -

        //BEGIN Zip
        [TestMethod]
        public void Zip_ZipTwoListsTogether_ListHasCorrectValues()
        {
            //Arrange
            CustomList<int> testListOne = new CustomList<int>();
            testListOne.Add(111);
            testListOne.Add(222);
            testListOne.Add(333);
            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(444);
            testListTwo.Add(555);
            testListTwo.Add(666);
            string expected = "111, 222, 333, 444, 555, 666";
            string actual;

            //Act
            actual = CustomList<int>.Zip(testListOne, testListTwo).ToString();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTWoListsTogether_ListHasCorrectCount()
        {
            //Arrange
            CustomList<int> testListOne = new CustomList<int>();
            testListOne.Add(111);
            testListOne.Add(222);
            testListOne.Add(333);
            CustomList<int> testListTwo = new CustomList<int>();
            testListTwo.Add(444);
            testListTwo.Add(555);
            testListTwo.Add(666);
            int expected = 6;
            int actual;

            //Act
            CustomList<int> result = CustomList<int>.Zip(testListOne, testListTwo);
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
