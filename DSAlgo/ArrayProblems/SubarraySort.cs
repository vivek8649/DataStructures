using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class SubarraySort
	{
		public static int[] SubarraySortFn(int[] array)
		{
			int startIndex = -1;
			int endIndex = -1;
			int lastSortedVal = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] < lastSortedVal)
				{
					for (int j = 0; j < i; j++)
					{
						if (array[j] > array[i])
						{
							if (startIndex == -1 || startIndex > j)
							{
								startIndex = j;
							}
							endIndex = i;
							break;
						}
					}
				}
				else
				{
					lastSortedVal = array[i];
				}
			}
			return new int[] { startIndex, endIndex };
		}
		public static int[] SubarraySortOn(int[] array)
		{
			int minIndexValue = Int32.MaxValue;
			int maxIndexValue = Int32.MinValue;

			for (int i = 0; i < array.Length; i++)
			{
				int num = array[i];
				if (isOutOfOrder(i, num, array))
				{
					minIndexValue = Math.Min(minIndexValue, num);
					maxIndexValue = Math.Max(maxIndexValue, num);
				}
			}

			if (minIndexValue == Int32.MaxValue)
			{
				return new int[] { -1, -1 };
			}

			int leftIndex = 0;
			while (array[leftIndex] <= minIndexValue)
			{
				leftIndex++;
			}

			int rightIndex = array.Length - 1;
			while (array[rightIndex] >= maxIndexValue)
			{
				rightIndex--;
			}

			return new int[] { leftIndex, rightIndex };
		}

		private static bool isOutOfOrder(int idx, int num, int[] array)
		{
			if (idx == 0)
			{
				return num > array[1];
			}
			if (idx == array.Length - 1)
			{
				return num < array[idx - 1];
			}
			return num > array[idx + 1] || num < array[idx - 1];
		}
	}
}
