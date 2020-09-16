using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.Strings
{
	public class PalindromeCheck
	{
		public static bool IsPalindrome(string str)
		{
			// Write your code here.
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
