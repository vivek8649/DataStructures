using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Strings
{
	public class UnderscorifySubstring
	{
		public static string UnderscorifySubstringFn(string str, string substring)
		{
			// Write your code here.

			var res = string.Empty;
			var array = str.Split(' ');

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Contains(substring))
				{
					if (array[i] == substring || isOverlapping(array[i], substring))
					{
						res += (" " + "_" + array[i] + "_");
					}
					else
					{
						var subArrays = array[i].Split(substring);
						res += (" " + string.Join("_" + substring + "_", subArrays));
					}
				}
				else
				{
					res += (" " + array[i]);
				}
			}

			return res;
		}

		private static bool isOverlapping(string str, string sub)
		{
			var right = str.Substring(str.Length - sub.Length, sub.Length);
			var left = str.Substring(0, sub.Length);

			return (left == sub && right == sub);

		}
	}
}
