using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	public class TwoNumberSum
	{
		public static int[] TwoNumberSumFn(int[] array, int targetSum)
		{

			Array.Sort(array);
			int left = 0;
			int right = array.Length - 1;

			while (left < right)
			{
				int currentSum = array[left] + array[right];
				if (currentSum < targetSum)
				{
					left++;     // small number + large number is  less than target so adding a less larger number will also be less 
								// so moving from left
				}
				else if (currentSum > targetSum)
				{
					right--;     // small number + large number is greater than target so adding another larger number will also make sum greater than target 
								 // so moving from right
				}
				else
				{
					var leftNumber = array[left];
					var rightNumber = array[right];
					return new int[] { leftNumber,rightNumber };
				}
			}
			return new int[] { -1, -1 };
		}
	}
}
