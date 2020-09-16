using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Strings
{
	public class PatternMatcher
	{
		public static string[] PatternMatcherFn(string pattern, string str)
		{
			// Write your code here.


			var updatedPattern = GetNewPattern(pattern);

			int yFirstIndexInPattern = -1;

			Dictionary<char, int> XYCounts = GetXYCountsAndYFirstIndex(updatedPattern, ref yFirstIndexInPattern);

			int yCount = XYCounts['y'];
			int xCount = XYCounts['x'];

			if (xCount + yCount != pattern.Length) return new string[] { };

			for (int xLength = 1; xLength <= str.Length; xLength++)
			{

				var xPattern = str.Substring(0, xLength);
				var result = string.Empty;

				if (yFirstIndexInPattern == -1)
				{
					foreach (var item in pattern)
					{
						result += xPattern;
					}

					if (result == str)
					{
						if (pattern[0] != updatedPattern[0])
						{

							return new string[] { "", xPattern };
						}
						else
						{
							return new string[] { xPattern, "" };
						}

					}
				}
				else
				{
					int yFirstIndexInString = xLength * yFirstIndexInPattern;
					int yLength = (str.Length - xCount * xLength) / yCount;
					if (yLength <= 0) break;
					var yPattern = str.Substring(yFirstIndexInString, yLength);

					result = GetResult(xPattern, yPattern, pattern, updatedPattern);

					if (string.Equals(result, str))
					{
						if (pattern[0] == updatedPattern[0])
						{
							return new string[] { xPattern, yPattern };
						}
						else
						{
							return new string[] { yPattern, xPattern };
						}

					}
				}



			}
			return new string[] { };
		}

		private static string GetResult(string xPattern, string yPattern, string pattern, string updatedPattern)
		{
			string res = string.Empty;

			if (pattern[0] == updatedPattern[0])
			{
				foreach (var item in pattern)
				{
					if (item == 'x')
					{
						res += xPattern;
					}
					else
					{
						res += yPattern;
					}
				}
			}
			else
			{
				foreach (var item in pattern)
				{
					if (item == 'x')
					{
						res += yPattern;
					}
					else
					{
						res += xPattern;
					}
				}
			}
			return res;
		}

		private static Dictionary<char, int> GetXYCountsAndYFirstIndex(string pattern, ref int yFirstIndex)
		{
			Dictionary<char, int> keyValuePairs = new Dictionary<char, int>() {
				{ 'x', 0},
				{ 'y', 0},
			};

			int index = 0;

			foreach (var item in pattern)
			{
				if (item == 'x')
				{
					keyValuePairs['x'] += 1;
				}
				else if (item == 'y')
				{
					if (yFirstIndex == -1)
					{
						yFirstIndex = index;
					}
					keyValuePairs['y'] += 1;
				}

				index++;
			}

			return keyValuePairs;
		}

		private static string GetNewPattern(string pattern)
		{

			if (pattern[0] == 'x') return pattern;

			int left = 0;
			int right = pattern.Length - 1;

			var patternArray = pattern.ToCharArray();

			while (left <= right)
			{
				if (patternArray[left] == 'x')
				{
					patternArray[left] = 'y';
				}
				else
				{
					patternArray[left] = 'x';
				}
				left++;

				if (left > right) break;

				if (patternArray[right] == 'x')
				{
					patternArray[right] = 'y';
				}
				else
				{
					patternArray[right] = 'x';
				}

				right--;
			}

			return new string(patternArray);
		}
	}
}
