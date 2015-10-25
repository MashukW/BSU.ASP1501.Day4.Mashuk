using System;
using NUnit.Framework;
using RefactoringJaggedSort;
using System.Collections.Generic;

namespace RefactoringJaggedSort.Test
{
    [TestFixture]
    public class SortByMaxModulElementTest
    {
        public IEnumerable<TestCaseData> TestDatasForSortByMaxModuleElement
        {
            get
            {
                yield return new TestCaseData(new int[] {}).Returns(0);
                yield return new TestCaseData(new int[] {1, 2, 5, 3, 4}).Returns(5);
                yield return new TestCaseData(new int[] {1, 3, 2, -8, 6, 5}).Returns(8);
                yield return new TestCaseData(null).Throws(typeof(ArgumentOutOfRangeException));
            }
        }
        
        [Test, TestCaseSource(nameof(TestDatasForSortByMaxModuleElement))]
        public int TestSortByMaxModulElementTest(int[] array)
        {
            return new SortByMaxModulElement().Сonditional(array);
        }
    }
}