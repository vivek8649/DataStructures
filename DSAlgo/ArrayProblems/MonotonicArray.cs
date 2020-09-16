using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class MonotonicArray
	{
		public static bool IsMonotonicFn1(int[] array)
		{
			// Write your code here.
			if (array.Length < 2) return true;

			int direction = array[1] - array[0];

			for (int i = 2; i < array.Length; i++)
			{
				if (direction == 0)
				{
					direction = array[i] - array[i - 1];
					continue;
				}
				if (direction > 0 && (array[i] - array[i - 1]) < 0) return false;
				if (direction < 0 && (array[i] - array[i - 1]) > 0) return false;
			}
			return true;
		}

		public static bool IsMonotonicFn2(int[] array)
		{
			// Write your code here.
			if (array.Length < 2) return true;

			bool isIncreasing = true;
			bool isDecreasing = true;

			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] < array[i - 1]) isIncreasing = false;
				if (array[i] > array[i - 1]) isDecreasing = false;
			}

			return isIncreasing || isDecreasing;
		}

		public static bool IsMonotonicFn0(int[] array)
		{
			// Write your code here.
			if (array.Length == 1 || array.Length == 0)
			{
				return true;
			}

			bool isIncreasing = false;

			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] != array[i - 1])
				{
					isIncreasing = array[i] > array[i - 1];
					break;
				}
			}

			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] != array[i - 1])
				{
					if (isIncreasing && array[i] < array[i - 1]) return false;
					if (!isIncreasing && array[i] > array[i - 1]) return false;
				}
			}
			return true;
		}
	}
}
