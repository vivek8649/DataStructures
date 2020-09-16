using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Strings
{
	public class SmallestSubstringContaining
	{
		public static string SmallestSubstringContainingFn(string bigstring, string smallstring)
		{
			// Write your code here.
			var uniqueCount = 0;
			int uniqueCountDone = 0;
			var smallStringHash = getSmallStringDictionary(smallstring, ref uniqueCount);

			int left = 0;
			int right = 0;

			var substring = string.Empty;
			var uniqueString = string.Empty;
			var subStringDictionary = new Dictionary<char, int>();
			var bounds = new List<int> { 0, Int32.MaxValue };

			while (right < bigstring.Length)
			{
				if (!smallStringHash.ContainsKey(bigstring[right]))
				{
					right++;
					continue;
				}

				// Add to dictionary
				if (!subStringDictionary.ContainsKey(bigstring[right]))
				{
					subStringDictionary.Add(bigstring[right], 1);
				}
				else
				{
					subStringDictionary[bigstring[right]] += 1;
				}

				if (subStringDictionary[bigstring[right]] == smallStringHash[bigstring[right]])
				{
					uniqueCountDone++;
				}


				while (uniqueCountDone == uniqueCount && left <= right)
				{
					bounds = (right - left) < (bounds[1] - bounds[0]) ? new List<int>() { left, right } : bounds;

					if (!smallStringHash.ContainsKey(bigstring[left]))
					{
						left++;
						continue;
					}

					if (subStringDictionary[bigstring[left]] == smallStringHash[bigstring[left]])
					{
						uniqueCountDone--;
					}

					subStringDictionary[bigstring[left]] -= 1;
					left++;
				}

				right++;
			}

			if (bounds[1] == Int32.MaxValue)
			{
				return string.Empty;
			}
			else
			{
				return bigstring.Substring(bounds[0], bounds[1] - bounds[0] + 1);
			}
		}

		private static Dictionary<char, int> getSmallStringDictionary(string smallstring, ref int uniqueCount)
		{
			var res = new Dictionary<char, int>();

			foreach (var item in smallstring)
			{
				if (res.ContainsKey(item))
				{
					res[item] += 1;
				}
				else
				{
					uniqueCount++;
					res.Add(item, 1);
				}
			}

			return res;
		}
	}
}
