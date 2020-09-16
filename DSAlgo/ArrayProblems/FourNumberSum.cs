using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class FourNumberSum
	{
		public static List<int[]> FourNumberSumFn(int[] array, int targetSum)
		{
			List<int[]> res = new List<int[]>();
			Dictionary<int, List<int[]>> dic = new Dictionary<int, List<int[]>>();

			for (int i = 0; i < array.Length - 1; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					int currSum = array[i] + array[j];
					int remSum = targetSum - currSum;
					if (dic.ContainsKey(remSum))
					{
						foreach (var pair in dic[remSum])
						{
							res.Add(new int[] { pair[0], pair[1], array[i], array[j] });
						}
					}
				}

				for (int k = 0; k < i; k++)
				{
					int currSum = array[k] + array[i];
					int[] pair = new int[] { array[k], array[i] };
					if (!dic.ContainsKey(currSum))
					{
						List<int[]> pairs = new List<int[]>();
						pairs.Add(pair);
						dic.Add(currSum, pairs);
					}
					else
					{
						dic[currSum].Add(pair);
					}
				}
			}
			return res;
		}

	}
}
