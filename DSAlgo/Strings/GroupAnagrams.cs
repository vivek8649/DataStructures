using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Strings
{
	public class GroupAnagrams
	{
		public static List<List<string>> groupAnagrams(List<string> words)
		{
			// Write your code here.
			Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

			foreach (var item in words)
			{
				var sortedKey = item.ToCharArray();

				Array.Sort(sortedKey);

				var key = new string(sortedKey);

				if (res.ContainsKey(key))
				{
					res[key].Add(item);
				}
				else
				{
					res.Add(key, new List<string>() { item });
				}

			}
			var result = new List<List<string>>();

			foreach (var item in res)
			{
				result.Add(item.Value);
			}

			return result;
		}
	}
}
