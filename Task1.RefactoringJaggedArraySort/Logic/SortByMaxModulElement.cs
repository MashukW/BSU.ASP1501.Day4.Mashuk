using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringJaggedSort
{
    public class SortByMaxModulElement : IConditionalSort
    {
        public int Сonditional(int[] array)
        {
            if (array == null)
                throw new ArgumentOutOfRangeException("parametr is null");
            if (array.Length == 0)
                return 0;

            int maxElement = Math.Abs(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                if (maxElement < Math.Abs(array[i]))
                    maxElement = Math.Abs(array[i]);
            }

            return maxElement;
        }
    }
}
