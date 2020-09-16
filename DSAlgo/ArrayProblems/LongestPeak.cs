using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class LongestPeak
	{
		public static int LongestPeakFn(int[] array)
		{
			// Write your code here.
			int longestPeak = 0;
			int i = 1;
			while (i < array.Length - 1)
			{
				bool isPeak = array[i - 1] < array[i] && array[i] > array[i + 1];
				if (!isPeak)
				{
					i++;
					continue;
				}

				int leftIdx = i - 2;
				while (leftIdx >= 0 && array[leftIdx] < array[leftIdx + 1])
				{
					leftIdx--;
				}

				int rightIdx = i + 2;
				while (rightIdx < array.Length && array[rightIdx - 1] > array[rightIdx])
				{
					rightIdx++;
				}

				int currentPeakLength = rightIdx - leftIdx - 1;

				if (currentPeakLength > longestPeak)
				{
					longestPeak = currentPeakLength;
				}

				i = rightIdx;
			}
			return longestPeak;
		}
	}
}
