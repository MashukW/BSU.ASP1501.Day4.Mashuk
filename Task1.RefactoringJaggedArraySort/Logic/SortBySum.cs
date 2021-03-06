﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringJaggedSort
{
    public class SortBySum : IConditionalSort
    {
        public int Сonditional(int[] array)
        {
            if (array == null)
                throw new ArgumentOutOfRangeException("parametr is null");
            if (array.Length == 0)
                return 0;

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }
    }
}
