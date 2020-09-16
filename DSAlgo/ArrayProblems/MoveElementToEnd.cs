using System;
using System.Collections.Generic;
using System.Text;

namespace DSAlgo.ArrayProblems
{
	class MoveElementToEnd
	{
		public static List<int> MoveElementToEndFn(List<int> array, int toMove)
		{
			// Write your code here.
			int left = 0;
			int right = array.Count - 1;

			while (left < right)
			{
				if (array[left] == toMove)
				{
					if (array[right] == toMove)
					{
						right--;
					}
					else
					{
						int temp = array[left];
						array[left] = toMove;
						array[right] = temp;
						left++;
					}
				}
				else {
					left++;
				}
			}
			return array;
		}
		public static List<int> MoveElementToEndFn2(List<int> array, int toMove)
		{
			// Write your code here.
			int left = 0;
			int right = array.Count - 1;

			while (left < right)
			{
				while (left < right && array[right] == toMove) right--;
				if (left < right && array[left] == toMove)
				{
					int temp = array[left];
					array[left] = array[right];
					array[right] = temp;
				}
				left++;
			}
			return array;
		}

			
	}
}
