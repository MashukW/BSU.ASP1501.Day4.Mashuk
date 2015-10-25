using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringJaggedSort
{
    public static class JaggedSort
    {
        public static void Sort(int[][] array, IConditionalSort sort) => Sort(array, sort, true);

        public static void Sort(int[][] array, IConditionalSort sort, bool keySort)
        {
            IConditionalSort conditional = sort as IConditionalSort;
            if (conditional == null)
                throw new ArgumentException("Parametr 'sort' is not IConditionalSort");

            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < array.GetLength(0); j++)
                {
                    if (array[j] != null)

                        if (array[i] == null)
                            Swap(ref array[i], ref array[j]);
                        else
                            Order(ref array[i], ref array[j], keySort, conditional);
                }
            }
        }

        private static void Swap(ref int[] array1, ref int[] array2)
        {
            int[] temp = array1;
            array1 = array2;
            array2 = temp;
        }

        private static void Order(ref int[] array1, ref int[] array2, bool key, IConditionalSort conditional)
        {
            if (key)
                if (conditional.Сonditional(array1) > conditional.Сonditional(array2))
                    Swap(ref array1, ref array2);
                else
                if (conditional.Сonditional(array1) < conditional.Сonditional(array2))
                    Swap(ref array1, ref array2);
        }
    }
}
