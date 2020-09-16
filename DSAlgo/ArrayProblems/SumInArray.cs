using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class SumInArray
	{
		public void Start()
		{
			int[] arr = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
			TwoNumberSum(arr, 10).ToList().ForEach(x => Console.Write(x + " "));

		}

		private static int[] TwoNumberSum(int[] array, int targetSum)
		{
			// Write your code here.
			HashSet<int> dict = new HashSet<int>();
			foreach (var item in array)
			{
				if (dict.Contains(targetSum - item)) return new int[] { item, targetSum - item };
				dict.Add(item);
			}
			List<int> list = new List<int>();

			list.ElementAt(0);
			return new int[0];
		}
	}
}
