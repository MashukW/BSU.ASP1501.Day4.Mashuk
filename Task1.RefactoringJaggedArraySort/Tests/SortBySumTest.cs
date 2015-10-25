using System;
using NUnit.Framework;
using RefactoringJaggedSort;
using System.Collections.Generic;

namespace RefactoringJaggedSort.Test
{
    [TestFixture]
    public class SortBySumTest
    {
        public IEnumerable<TestCaseData> TestDatasSumArrayMethod
        {
            get
            {
                yield return new TestCaseData(new int[] {1, 2, 3, 4, 5}).Returns(15);
                yield return new TestCaseData(null).Throws(typeof(ArgumentOutOfRangeException));
            }
        }

        [Test, TestCaseSource(nameof(TestDatasSumArrayMethod))]
        public int TestSumArrayMethod(int[] array)
        {
            return new SortBySum().Сonditional(array);
        }
    }
}