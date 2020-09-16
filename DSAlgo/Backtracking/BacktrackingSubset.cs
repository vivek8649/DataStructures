using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo
{
	class BacktrackingSubset
	{
		public static List<List<int>> result = new List<List<int>>();
		public void subsets(List<int> A)
		{
			List<int> sub = new List<int>();
			result.Add(sub);
			Util(0, sub, A);
			foreach (var item in result) {
				foreach (var x in item) {
					Console.Write(x + " ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}

		public static void Util(int index, List<int> sub, List<int> A)
		{
			for (int i = index; i < A.Count; i++)
			{
				var temp = new List<int>(sub);
				temp.Add(A[i]);
				result.Add(temp);
				Util(i + 1, temp, A);
			}
			return;
		}
	}
}
