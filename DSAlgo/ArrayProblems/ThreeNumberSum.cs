using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	static class ThreeNumberSum
	{
		public static List<int[]> ThreeNumberSumFunction(int[] array, int targetSum)
		{
			Array.Sort(array);
			var result = new List<int[]>();

			for (int i = 0; i < array.Length - 2; i++)
			{
				int left = i + 1;
				int right = array.Length - 1;

				while (left < right)
				{
					int sum = array[i] + array[left] + array[right];
					if (sum == targetSum)
					{
						result.Add(new int[] { array[i], array[left], array[right] });
						left++;
						right--;
					}
					else if (sum < targetSum)
					{
						left++;
					}
					else
					{
						right--;
					}
				}
			}

			return result;
		}

		public static List<int[]> ThreeNumberSumPractise(int[] array, int targetSum)
		{
			Array.Sort(array);

			List<int[]> res = new List<int[]>();

			for (int i = 0; i < array.Length; i++)
			{
				int left = i + 1;
				int right = array.Length - 1;

				while (left < right)
				{
					int currentSum = array[i] + array[left] + array[right];

					if (currentSum < targetSum)
					{
						left++;
					}
					else if (currentSum > targetSum)
					{
						right--;
					}
					else
					{
						left++;
						right--;
						res.Add(new int[] { array[i], array[left], array[right] });
					}
				}
			}

			return res;
		}
	}
}
