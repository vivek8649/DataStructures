using System;
using System.Collections.Generic;
using System.Linq;

namespace DSAlgo
{
	class BacktrackingCommbinationSum
	{
		public void combinationSum(List<int> A, int B)
		{
			List<int> arr = new List<int>();
			List<List<int>> result = new List<List<int>>();
			A.Sort();
			CombUtil(arr, ref result, 0, A, B, B);

			Console.WriteLine("******* Result *******");
			foreach (var item in result)
			{
				foreach (var x in item)
				{
					Console.Write(x + " ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}

		public void CombUtil(List<int> arr, ref List<List<int>> result, int startIndex, List<int> A, int target, int n)
		{
			if (target == 0)
			{
				result.Add(new List<int>(arr));
				return;
			}

			for (int i = startIndex; i < A.Count; i++)
			{  
				if((i!= startIndex) && A[i] == A[i - 1]) continue;
				if (A[i] > target)
				{
					break;
				}
				arr.Add(A[i]);
				CombUtil(arr, ref result, i, A, target - A[i], n);
				arr.Remove(A[i]);
			}
		}
	}
}
