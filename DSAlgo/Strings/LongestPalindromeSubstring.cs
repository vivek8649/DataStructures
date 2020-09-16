using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Strings
{
	public class LongestPalindromeSubstring
	{
		public static string LongestPalindromicSubstringON2(string str)
		{
			int[] currentLongest = new int[] { 0, 1 };

			for (int i = 1; i < str.Length; i++)
			{
				int[] odd = GetPalindrome(str, i - 1, i + 1);
				int[] even = GetPalindrome(str, i - 1, i);
				int[] longest = (odd[1] - odd[0]) > (even[1] - even[0])
								? odd : even;
				currentLongest = (currentLongest[1] - currentLongest[0]) > (longest[1] - longest[0])
								? currentLongest : longest;

			}
			return str.Substring(currentLongest[0], currentLongest[1] - currentLongest[0] + 1);
		}

		private static int[] GetPalindrome(string str, int left, int right)
		{
			while (left >= 0 && right < str.Length)
			{
				if (str[left] != str[right])
				{
					break;
				}
				left--;
				right++;
			}
			return new int[] { left + 1, right - 1 };
		}

		public static string LongestPalindromicSubstring(string str)
		{
			// Write your code here.
			int max = Int32.MinValue;
			string res = string.Empty;

			for (int i = 0; i < str.Length; i++)
			{
				for (int j = i; j < str.Length; j++)
				{
					var substring = str.Substring(i, j + 1 - i);
					if (substring.Length > max && isPalindrome(substring))
					{
						res = substring;
						max = substring.Length;
					}
				}
			}
			return res;
		}

		private static bool isPalindrome(string str)
		{
			int left = 0;
			int right = str.Length - 1;
			bool isPalin = true;

			while (left <= right)
			{
				if (str[left] != str[right])
				{
					isPalin = false;
					break;
				}
				left++;
				right--;
			}
			return isPalin;

		}
	}
}
