using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	public class LargestRange
	{
		public static int[] LargestRangeFn(int[] array)
		{
			if (array.Length == 1)
			{
				return new int[] { array[0], array[0] };
			}

			Array.Sort(array);

			int start = array[0];
			Dictionary<int, int> dict = new Dictionary<int, int>();
			dict.Add(start, start);
			for (int i = 0; i < array.Length - 1; i++)
			{
				if ((array[i + 1] - array[i]) == 1)
				{
					if (dict.ContainsKey(start))
					{
						dict[start] = array[i + 1];
					}
					else
					{
						dict.Add(start, array[i + 1]);
					}
				}
				else if ((array[i + 1] == array[i]))
				{
					continue;
				}
				else
				{
					start = array[i + 1];
					if (!dict.ContainsKey(start))
					{
						dict.Add(start, array[i + 1]);
					}
				}
			}

			int len = Int32.MinValue;
			int[] res = new int[2];

			foreach (var item in dict)
			{
				if (len < (item.Value - item.Key))
				{
					len = item.Value - item.Key;
					res = new int[] { item.Key, item.Value };
				}
			}
			return res;
		}

		public static int[] LargestRangeOn(int[] array)
		{
			// Write your code here.
			int[] bestLength = new int[2];
			HashSet<int> nums = new HashSet<int>();
			int longestLength = 0;
			foreach (var item in array)
			{
				nums.Add(item);
			}

			foreach (var num in array)
			{
				if (!nums.Contains(num))
				{
					continue;
				}

				nums.Remove(num);

				int left = num - 1;
				int right = num + 1;
				int currentLength = 1;

				while (nums.Contains(left))
				{
					nums.Remove(left);
					currentLength++;
					left--;
				}

				while (nums.Contains(right))
				{
					nums.Remove(right);
					currentLength++;
					right++;
				}

				if (currentLength > longestLength)
				{
					longestLength = currentLength;
					bestLength = new int[] { left + 1, right - 1 };
				}

			}
			return bestLength;
		}
	}
}
