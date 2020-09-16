using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Strings
{
	public class LongestSubstringWithoutDuplicates
	{
		public static string LongestSubstringWithoutDuplication(string str)
		{
			// Write your code here
			Dictionary<char, int> hash = new Dictionary<char, int>();

			int[] index = new int[2] { 0, 0 };
			int[] max = new int[2] { 0, 0 };
			hash.Add(str[0], 0);

			for (int i = 1; i < str.Length; i++)
			{

				if (hash.ContainsKey(str[i]))
				{
					if ((max[1] - max[0]) < (index[1] - index[0]))
					{
						max[1] = index[1];
						max[0] = index[0];
					}

					index[0] = hash[str[i]] + 1;
					index[1] = i;

					var x = hash[str[i]];

					for (int j = 0; j <= x; j++)
					{
						hash.Remove(str[j]);
					}

					hash.Clear();
				}
				else
				{
					index[1] = i;
				}
				hash.Add(str[i], i);
			}

			if ((max[1] - max[0]) < (index[1] - index[0]))
			{
				max[1] = index[1];
				max[0] = index[0];
			}

			return str.Substring(max[0], max[1] + 1 - max[0]);
		}
	}
}
