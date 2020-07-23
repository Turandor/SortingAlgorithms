using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting_Alghotihm;
using System.Collections.Generic;
using System;


namespace SortingAlgorithmTests
{
    [TestClass]
    public class SortingAlgorithmTests
    {
        [TestMethod]
        public void BubbleSort_Sorting()
        {
            // Arrange
            BubbleSort bubbleSort = new BubbleSort();
            Random random = new Random();
            const int length = 1000, lowerBound = 0, upperBound = 1000;
            List<int> task = new List<int>();
            bool isSortingCorrect = true;
            for (int i = 0; i < length; i++)
            {
                task.Add(random.Next(lowerBound, upperBound));
            }
            bubbleSort.LoadTask(task);

            // Act
            task = bubbleSort.Sort();
            for (int i = 0; i < length-1; i++)
            {
                if (task[i] > task[i + 1])
                    isSortingCorrect = false;
            }
            // Assert
            Assert.IsTrue(isSortingCorrect, "Sorting went wrong.");
        }
    }
}
