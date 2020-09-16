using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo
{
	class BacktrackingCombination
	{
		public void combine(int A, int B)
		{
			List<int> a = new List<int>();
			List<List<int>> result = new List<List<int>>();
			Util(1, a, A, result, B);
			Console.WriteLine("******* Result *******");
			foreach (var item in result) {
				foreach (var x in item) {
					Console.Write(x+ " ");
				}
				Console.WriteLine();
			}
		}

		public void Util(int start, List<int> A, int n, List<List<int>> result, int k)
		{
			if (k == 0)
			{
				result.Add(A);
				foreach (var item in A) {
					Console.Write(item);
				}
				Console.WriteLine();
			}

			else
			{
				for (int i = start; i <= n; i++)
				{
					A.Add(i);
					Util(i + 1, A, n, result, k - 1);
					A.Remove(i);
				}
			}
		}
	}
}
