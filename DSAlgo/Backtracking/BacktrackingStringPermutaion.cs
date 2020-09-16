using System;
using System.Collections.Generic;
using System.Linq;

namespace DSAlgo
{
	class BacktrackingStringPermutaion
	{
		public BacktrackingStringPermutaion() { }


		static string inputString = Console.ReadLine();
		static int level = 0;
		static char[] result = new char[inputString.Length];
		static char[] str = inputString.ToCharArray().Distinct().ToArray();
		static int[] count = new int[str.Length];

		public void createInputData()
		{
			for (int i = 0; i < str.Length; i++)
			{
				int countOfCh = 0;
				for (int j = 0; j < inputString.Length; j++)
				{
					if (str[i] == inputString[j])
					{
						countOfCh++;
					}
				}
				count[i] = countOfCh;
			}
			PermutUtil(str, result, 0);
		}
		public static void PermutUtil(char[] str, char[] result, int level)
		{
			if (level == result.Length)
			{
				foreach (var item in result)
				{
					Console.Write(item);
				}
				Console.WriteLine();
				Console.ReadLine();
				return;
			}
			for (int i = 0; i < str.Length; i++)
			{
				if (count[i] == 0)
					continue;

				result[level] = str[i];
				count[i]--;
				PermutUtil(str, result, level + 1);
				count[i]++;
			}

		}
	}
}
