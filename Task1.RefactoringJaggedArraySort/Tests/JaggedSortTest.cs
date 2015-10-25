using System;
using NUnit.Framework;
using RefactoringJaggedSort;
using System.Collections.Generic;
using System.Text;

namespace RefactoringJaggedSort.Test
{
    [TestFixture]
    public class JaggedSortTest
    {
        [Test]
        public void TestJaggedSort_ConditionalSortBySum()
        {
            
        }

        private static string ToStringArray(int[][] array)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] == null)
                {
                    str.Append("null\n");
                    continue;
                }

                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j != array[i].Length - 1)
                        str.Append(array[i][j] + " ");
                    else
                        str.Append(array[i][j] + "\n");
                }
            }

            return str.ToString();
        }
    }
}
